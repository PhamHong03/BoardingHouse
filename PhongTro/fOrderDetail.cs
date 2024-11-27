using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;

namespace PhongTro
{
    public partial class fOrderDetail : Form
    {
        Function func = new Function();

        SqlConnection conn = new SqlConnection();

        public fOrderDetail()
        {
            InitializeComponent();
        }

        private void fOrderDetail_Load(object sender, EventArgs e)
        {
            func.Connect(conn);

            func.LoadOrderDetail(dataGridViewLoadOrderDetail, conn, "SELECT * FROM CHI_TIET_HD");
            comboBoxContract.MaxDropDownItems = 15;
            comboBoxContract.IntegralHeight = false;

            func.LoadComBoBox(" SELECT * FROM  HOP_DONG_THUE WHERE THOI_HAN > GETDATE()", conn, comboBoxContract, comboBoxContract.DisplayMember, comboBoxContract.ValueMember);
        }
        private void btnAddOrderDetail_Click(object sender, EventArgs e)
        {
            string max_hdt = "select MAX(substring(MaCTHD, 3,5))+1 FROM CHI_TIET_HD";

            SqlCommand cmd = new SqlCommand(max_hdt, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int new_ms = int.Parse(reader[0].ToString());
                if (new_ms < 10)
                {
                    txtIdOrder.Text = "CT00" + new_ms;
                }
                else if (new_ms < 100)
                {
                    txtIdOrder.Text = "CT0" + new_ms;

                }
                else if (new_ms < 100)
                {
                    txtIdOrder.Text = "CT" + new_ms;

                }
                else
                {
                    MessageBox.Show("Reset Ma hop dong di pro");
                }
            }
            txtIdOrder.Enabled = false;
            reader.Close();
        }


        public int getThang()
        {

            string query = " SELECT MAX(MONTH(NgayThang)) AS ThangMax,YEAR(NgayThang) AS NamMax FROM CHI_TIET_HD WHERE YEAR(NgayThang) = (SELECT MAX(YEAR(NgayThang)) FROM CHI_TIET_HD)";

            SqlCommand cmd = new SqlCommand(query, conn);

            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            return 0;
        }

        private void btnSaveOrderDetail_Click(object sender, EventArgs e)
        {
            string id = txtIdOrder.Text;
            string id_hdt = comboBoxContract.SelectedValue.ToString();
            string time = dateTimePickerDetailOrder.Value.ToString("yyyy-MM-dd");
            string water = txtWaterOrderDetail.Text;
            string electronic = txtElectOrderDetail.Text;
            string sql = "INSERT INTO CHI_TIET_HD VALUES ('" + id + "', '" + id_hdt + "', '" + time + "', '" + electronic + "', '" + water + "')";

            string MaHDT = comboBoxContract.SelectedValue.ToString();

            string checkElectricityWater = @"
                        SELECT CSD, CSN 
                        FROM CHI_TIET_HD 
                        WHERE NgayThang = (SELECT MAX(NgayThang) FROM CHI_TIET_HD WHERE MaHDT = @MaHDT)
                        AND MaHDT = @MaHDT";
            //string checkElectricityWater2 = @"
            //       SELECT ct.CSD, ct.CSN, hdt.THOI_HAN
            //           FROM CHI_TIET_HD ct
            //           INNER JOIN HOP_DONG_THUE hdt ON ct.MaHDT = hdt.MaHDT
            //           WHERE ct.NgayThang = (
            //               SELECT MAX(NgayThang)
            //               FROM CHI_TIET_HD
            //               WHERE MaHDT = @MaHDT
            //           )
            //           AND ct.MaHDT = @MaHDT;";


            SqlCommand checkCmd = new SqlCommand(checkElectricityWater, conn);
            checkCmd.Parameters.AddWithValue("@MaHDT", MaHDT);

            SqlDataReader checkReader = checkCmd.ExecuteReader();

            if (checkReader.Read())
            {
                int previousCSD = int.Parse(checkReader["CSD"].ToString());
                int previousCSN = int.Parse(checkReader["CSN"].ToString());

                //DateTime thoihan = DateTime.Parse(checkReader["THOI_HAN"].ToString());

                //DateTime selectedDate = DateTime.Parse(time);
                int currentCSD = int.Parse(txtElectOrderDetail.Text);
                int currentCSN = int.Parse(txtWaterOrderDetail.Text);


                if ((currentCSD <= previousCSD || currentCSN <= previousCSN))
                {
                    MessageBox.Show("Chỉ số điện, nước tháng này phải lớn hơn chỉ số điện, nước tháng trước.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    checkReader.Close();
                    return;
                }

                //if (selectedDate > thoihan)
                //{
                //    MessageBox.Show("Ngày được chọn không được vượt quá thời hạn hợp đồng.");
                //    checkReader.Close();
                //    return;
                //}
            }

            checkReader.Close();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Chi tiết hóa đơn đã thêm thành công!", "Thông báo", MessageBoxButtons.OKCancel);
            func.LoadOrderDetail(dataGridViewLoadOrderDetail, conn, "SELECT * FROM CHI_TIET_HD");

        }

        private void dataGridViewLoadOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdOrder.Text = dataGridViewLoadOrderDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxContract.Text = dataGridViewLoadOrderDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtElectOrderDetail.Text = dataGridViewLoadOrderDetail.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtWaterOrderDetail.Text = dataGridViewLoadOrderDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePickerDetailOrder.Text = dataGridViewLoadOrderDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            string MaHDT = comboBoxContract.SelectedValue?.ToString();
            string Month = dateTimePickerDetailOrder.Value.Month.ToString();
            string Year = dateTimePickerDetailOrder.Value.Year.ToString();
            if (string.IsNullOrEmpty(MaHDT))
            {
                MessageBox.Show("Vui lòng chọn hợp đồng thuê.");
                return;
            }

            string sql = @"
    WITH SelectedMonth AS (
        SELECT 
            MaHDT, 
            NgayThang, 
            CSD, 
            CSN,
            ROW_NUMBER() OVER (PARTITION BY MaHDT ORDER BY NgayThang DESC) AS RowNum
        FROM 
            CHI_TIET_HD
        WHERE 
            MaHDT = @MaHDT
            AND (
                (MONTH(NgayThang) = @Month AND YEAR(NgayThang) = @Year) 
                OR (MONTH(NgayThang) = @Month - 1 AND YEAR(NgayThang) = @Year)
                OR (MONTH(NgayThang) = 12 AND YEAR(NgayThang) = @Year - 1 AND @Month = 1)
            )
    )
    SELECT  
        hdt.MaHDT, 
        kh.TenKH AS KHÁCH,
        phong.TenPhong AS PHÒNG,
        CASE 
            WHEN COALESCE(S1.CSD - COALESCE(S2.CSD, 0), S1.CSD) = S1.CSD THEN S1.CSD * 3500
            ELSE (S1.CSD - COALESCE(S2.CSD, 0)) * 3500
        END AS ĐIỆN, 
        CASE 
            WHEN COALESCE(S1.CSN - COALESCE(S2.CSN, 0), S1.CSN) = S1.CSN THEN S1.CSN * 15000
            ELSE (S1.CSN - COALESCE(S2.CSN, 0)) * 15000
        END AS NƯỚC, 
        phong.Gia AS GIÁ,
        phong.Gia + 
            CASE 
                WHEN COALESCE(S1.CSD - COALESCE(S2.CSD, 0), S1.CSD) = S1.CSD THEN S1.CSD * 3500
                ELSE (S1.CSD - COALESCE(S2.CSD, 0)) * 3500
            END + 
            CASE 
                WHEN COALESCE(S1.CSN - COALESCE(S2.CSN, 0), S1.CSN) = S1.CSN THEN S1.CSN * 15000
                ELSE (S1.CSN - COALESCE(S2.CSN, 0)) * 15000
            END AS TỔNG 
    FROM 
        HOP_DONG_THUE hdt
    JOIN 
        SelectedMonth AS S1 ON hdt.MaHDT = S1.MaHDT AND S1.RowNum = 1
    LEFT JOIN 
        SelectedMonth AS S2 ON hdt.MaHDT = S2.MaHDT AND S2.RowNum = 2
    JOIN 
        PHONG phong ON hdt.MaPhong = phong.MaPhong
    JOIN 
        KHACHHANG AS kh ON kh.MaKH = hdt.MaKH 
    WHERE 
        hdt.MaHDT = @MaHDT;
";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaHDT", MaHDT);
                cmd.Parameters.AddWithValue("@Month", Month);
                cmd.Parameters.AddWithValue("@Year", Year);


                try
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewLoadOrderDetail.DataSource = dataTable;
                        dataGridViewLoadOrderDetail.Columns["GIÁ"].DefaultCellStyle.Format = "C0";
                        dataGridViewLoadOrderDetail.Columns["GIÁ"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                        dataGridViewLoadOrderDetail.Columns["TỔNG"].DefaultCellStyle.Format = "C0";
                        dataGridViewLoadOrderDetail.Columns["TỔNG"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Lỗi SQL: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }

            //string sql = "SELECT * FROM CHI_TIET_HD WHERE MaHDT = '" + MaHDT + "'";
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.ExecuteNonQuery();
            ////MessageBox.Show("Xoá thành công");
            //func.LoadOrderDetail(dataGridViewLoadOrderDetail, conn, sql);
        }

        private void btnResetOrderDetail_Click(object sender, EventArgs e)
        {
            txtIdOrder.Clear();
            txtElectOrderDetail.Clear();
            txtWaterOrderDetail.Clear();
        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            string id = txtIdOrder.Text;

            string sql = "DELETE FROM CHI_TIET_HD WHERE MaCTHD = '" + id + "'";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OKCancel);
            func.LoadOrderDetail(dataGridViewLoadOrderDetail, conn, "SELECT * FROM CHI_TIET_HD");
        }


        private void btnEditOrderDetail_Click(object sender, EventArgs e)
        {
            string id = txtIdOrder.Text;
            string id_hdt = comboBoxContract.SelectedValue.ToString();
            string time = dateTimePickerDetailOrder.Value.ToString("yyyy-MM-dd");
            string water = txtWaterOrderDetail.Text;
            string electronic = txtElectOrderDetail.Text;

            string sql = "UPDATE CHI_TIET_HD SET MaHDT = '" + id_hdt + "', NgayThang = '" + time + "', CSD = '" + electronic + "', CSN = '" + water + "' WHERE MaCTHD = '" + id + "'";


            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Chi tiết hóa đơn đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OKCancel);
            func.LoadOrderDetail(dataGridViewLoadOrderDetail, conn, "SELECT * FROM CHI_TIET_HD");
        }

        private void comboBoxContract_SelectedIndexChanged(object sender, EventArgs e)
        {

            string MaHDT = comboBoxContract.SelectedValue?.ToString();
            string sql = "SELECT * FROM CHI_TIET_HD WHERE MaHDT = '" + MaHDT + "' ORDER BY YEAR(NgayThang) DESC, MONTH(NgayThang) DESC ";

            //string sql = "SELECT * FROM CHI_TIET_HD ct, HOP_DONG_THUE hdt WHERE ct.MaHDT = hdt.MaHDT AND ct.MaHDT = 'HD004' AND hdt.THOI_HAN < GETDATE() ORDER BY YEAR(NgayThang) DESC, MONTH(NgayThang) DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            func.LoadOrderDetail(dataGridViewLoadOrderDetail, conn, sql);
        }

        private void btnPrintOrderDetail_Click(object sender, EventArgs e)
        {
            fPrintOrderDetail fPrintRoom = new fPrintOrderDetail();
            Point pictureBoxLocation = groupBox1.PointToScreen(Point.Empty);
            fPrintRoom.StartPosition = FormStartPosition.Manual;
            fPrintRoom.Location = pictureBoxLocation;
            fPrintRoom.Show();
        }

        private void txtSearchOrderDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tukhoa = txtSearchOrderDetails.Text;
                string sql = "SELECT * FROM CHI_TIET_HD WHERE MaHDT LIKE '%" + tukhoa + "%' OR MaCTHD LIKE '%" + tukhoa + "%'";

                func.LoadOrderDetail(dataGridViewLoadOrderDetail, conn, sql);
            }
        }

        private void txtWaterOrderDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) & !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtElectOrderDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) & !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

    }
}
