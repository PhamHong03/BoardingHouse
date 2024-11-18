using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ClosedXML.Excel;

namespace PhongTro
{
    public partial class fContract : Form
    {
        SqlConnection conn = new SqlConnection();

        Function func = new Function();
        public fContract()
        {
            InitializeComponent();
        }

        private void fContract_Load(object sender, EventArgs e)
        {
            func.Connect(conn);
            func.LoadComBoBox("SELECT * FROM KHACHHANG", conn, comboBoxLoadCustomer, comboBoxLoadCustomer.DisplayMember, comboBoxLoadCustomer.ValueMember);
            func.LoadComBoBox("SELECT * FROM PHONG", conn, comboBoxLoadRoom, comboBoxLoadRoom.DisplayMember, comboBoxLoadRoom.ValueMember);

            string query = "SELECT H.MaHDT, H.NGAY_THUE, H.THOI_HAN, H.NOI_DUNG, K.TenKH AS 'KH', P.TenPhong AS 'TEN PHONG' FROM HOP_DONG_THUE H JOIN KHACHHANG K ON H.MaKH = K.MaKH JOIN PHONG P ON H.MaPhong = P.MaPhong";
            func.LoadContract(dataGridViewLoadContract, conn, query);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string max_hdt = "select MAX(substring(MaHDT, 3,5))+1 FROM HOP_DONG_THUE";

            SqlCommand cmd = new SqlCommand(max_hdt, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int new_ms = int.Parse(reader[0].ToString());
                if (new_ms < 10)
                {
                    txtIdContract.Text = "HD00" + new_ms;
                }
                else if (new_ms < 100)
                {
                    txtIdContract.Text = "HD0" + new_ms;

                }
                else if (new_ms < 100)
                {
                    txtIdContract.Text = "KD" + new_ms;

                }
                else
                {
                    MessageBox.Show("Reset Ma hop dong di pro");
                }
            }

            txtIdContract.Enabled = false;
            reader.Close();
        }

        private void btnSaveContract_Click(object sender, EventArgs e)
        {
            string id = txtIdContract.Text;
            string ngay = dateTimePickerContract.Value.ToString("yyyy-MM-dd");
            string expire = dateTimePickerContractExpire.Value.ToString("yyyy-MM-dd");
            string content = txtContentContract.Text;
            string makh = comboBoxLoadCustomer.SelectedValue.ToString();
            string mp = comboBoxLoadRoom.SelectedValue.ToString();


            string checkRoomQuery = @"SELECT COUNT(*) 
                              FROM HOP_DONG_THUE 
                              WHERE MaPhong = @MaPhong 
                              AND ((@ngay >= NGAY_THUE AND @ngay <= THOI_HAN) 
                              OR (@expire >= NGAY_THUE AND @expire <= THOI_HAN))";

            SqlCommand checkRoomCommand = new SqlCommand(checkRoomQuery, conn);
            checkRoomCommand.Parameters.AddWithValue("@MaPhong", mp);
            checkRoomCommand.Parameters.AddWithValue("@ngay", ngay);
            checkRoomCommand.Parameters.AddWithValue("@expire", expire);

            int roomCount = (int)checkRoomCommand.ExecuteScalar();

            if (roomCount > 0)
            {
                MessageBox.Show("Phòng này đang trong thời gian thuê. Vui lòng chọn phòng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "INSERT INTO HOP_DONG_THUE VALUES ('" + id + "','" + ngay + "', N'" + expire + "', N'" + content + "', '" + makh + "' , '" + mp + "')";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Tạo hợp đồng thành công!");
            string query = "SELECT H.MaHDT, H.NGAY_THUE, H.THOI_HAN, H.NOI_DUNG, K.TenKH AS 'KH', P.TenPhong AS 'TEN PHONG' FROM HOP_DONG_THUE H JOIN KHACHHANG K ON H.MaKH = K.MaKH JOIN PHONG P ON H.MaPhong = P.MaPhong";
            func.LoadContract(dataGridViewLoadContract, conn, query);
        }

        private void dataGridViewLoadContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdContract.Text = dataGridViewLoadContract.Rows[e.RowIndex].Cells[0].Value.ToString();
            dateTimePickerContract.Text = dataGridViewLoadContract.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePickerContractExpire.Text = dataGridViewLoadContract.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtContentContract.Text = dataGridViewLoadContract.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxLoadCustomer.Text = dataGridViewLoadContract.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBoxLoadRoom.Text = dataGridViewLoadContract.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnDeleteContract_Click(object sender, EventArgs e)
        {
            string id = txtIdContract.Text;

            string sql = "DELETE FROM HOP_DONG_THUE WHERE MaHDT = '" + id + "'";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Xóa hợp đồng thành công!");
            string query = "SELECT H.MaHDT, H.NGAY_THUE, H.THOI_HAN, H.NOI_DUNG, K.TenKH AS 'KH', P.TenPhong AS 'TEN PHONG' FROM HOP_DONG_THUE H JOIN KHACHHANG K ON H.MaKH = K.MaKH JOIN PHONG P ON H.MaPhong = P.MaPhong";
            func.LoadContract(dataGridViewLoadContract, conn, query);

        }

        private void btnEditContract_Click(object sender, EventArgs e)
        {
            string id = txtIdContract.Text;
            string ngay = dateTimePickerContract.Value.ToString("yyyy-MM-dd");
            string expire = dateTimePickerContractExpire.Value.ToString("yyyy-MM-dd");
            string content = txtContentContract.Text;

            string sql = "UPDATE HOP_DONG_THUE SET NGAY_THUE = '" + ngay + "', THOI_HAN = '" + expire + "', NOI_DUNG = '" + content + "' WHERE MaHDT = '" + id + "' ";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Cập nhật hợp đồng thành công!");
            string query = "SELECT H.MaHDT, H.NGAY_THUE, H.THOI_HAN, H.NOI_DUNG, K.TenKH AS 'KH', P.TenPhong AS 'TEN PHONG' FROM HOP_DONG_THUE H JOIN KHACHHANG K ON H.MaKH = K.MaKH JOIN PHONG P ON H.MaPhong = P.MaPhong";
            func.LoadContract(dataGridViewLoadContract, conn, query);
        }

        private void btnResetContract_Click(object sender, EventArgs e)
        {
            txtIdContract.Clear();
            txtContentContract.Clear();
        }

        private void txtContentContract_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrintContract_Click(object sender, EventArgs e)
        {
            fPrintContract fPrintRoom = new fPrintContract();
            Point pictureBoxLocation = groupBox1.PointToScreen(Point.Empty);
            fPrintRoom.StartPosition = FormStartPosition.Manual;
            fPrintRoom.Location = pictureBoxLocation;
            fPrintRoom.Show();
        }

        private void btnExportContract_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel File (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.FileName = "DanhSachHopDongThue";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    exportExcel(dataGridViewLoadContract, filePath);
                    MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void exportExcel(DataGridView dataGridView, string filePath)
        {

        }


        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void txtSearchContract_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tukhoa = txtSearchContract.Text;
                string sql = "SELECT H.MaHDT, H.NGAY_THUE, H.THOI_HAN, H.NOI_DUNG, K.TenKH AS 'KH', P.TenPhong AS 'TEN PHONG' FROM HOP_DONG_THUE H JOIN KHACHHANG K ON H.MaKH = K.MaKH JOIN PHONG P ON H.MaPhong = P.MaPhong AND MaHDT LIKE '%" + tukhoa + "%'";

                func.LoadContract(dataGridViewLoadContract, conn, sql);
            }
        }
    }
}
