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

            func.LoadComBoBox("SELECT * FROM HOP_DONG_THUE", conn, comboBoxContract, comboBoxContract.DisplayMember, comboBoxContract.ValueMember);
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

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Chi tiết hóa đơn đã thêm thành công!");
            func.LoadOrderDetail(dataGridViewLoadOrderDetail, conn, "SELECT * FROM CHI_TIET_HD");
        }

        private void dataGridViewLoadOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdOrder.Text = dataGridViewLoadOrderDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxContract.Text = dataGridViewLoadOrderDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtElectOrderDetail.Text = dataGridViewLoadOrderDetail.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtWaterOrderDetail.Text = dataGridViewLoadOrderDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            string MaHDT = comboBoxContract.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(MaHDT))
            {
                MessageBox.Show("Vui lòng chọn hợp đồng thuê.");
                return;
            }

            string sql = @"
                WITH LatestMonths AS (
                    SELECT 
                        MaHDT, 
                        NgayThang, 
                        CSD, 
                        CSN, 
                        ROW_NUMBER() OVER (PARTITION BY MaHDT ORDER BY NgayThang DESC) AS RowNum 
                    FROM CHI_TIET_HD
                ),
                PreviousMonth AS (
                    SELECT 
                        MaHDT,
                        CSD AS CSD_Truoc,
                        CSN AS CSN_Truoc,
                        NgayThang AS NgayThang_Truoc
                    FROM CHI_TIET_HD
                    WHERE 
                        (MONTH(NgayThang) = 12 AND YEAR(NgayThang) = YEAR((SELECT MAX(NgayThang) FROM CHI_TIET_HD)) - 1) 
                        OR (NgayThang = (SELECT MAX(NgayThang) FROM CHI_TIET_HD WHERE MaHDT = @MaHDT))
                )
                SELECT  
                    hdt.MaHDT, 
                    kh.TenKH AS KHÁCH,
                    phong.TenPhong AS PHÒNG,
                    CASE 
                        WHEN COALESCE(L1.CSD - COALESCE(L2.CSD, P.CSD_Truoc), L1.CSD) = 0 THEN L1.CSD * 3.5
                        ELSE (L1.CSD - COALESCE(L2.CSD, P.CSD_Truoc)) * 3.5
                    END AS ĐIỆN, 
                    CASE 
                        WHEN COALESCE(L1.CSN - COALESCE(L2.CSN, P.CSN_Truoc), L1.CSN) = 0 THEN L1.CSN * 15
                        ELSE (L1.CSN - COALESCE(L2.CSN, P.CSN_Truoc)) * 15
                    END AS NƯỚC, 
                    phong.Gia AS GIÁ,
                    phong.Gia + 
                        CASE 
                            WHEN COALESCE(L1.CSD - COALESCE(L2.CSD, P.CSD_Truoc), L1.CSD) = 0 THEN L1.CSD * 3.5
                            ELSE (L1.CSD - COALESCE(L2.CSD, P.CSD_Truoc)) * 3.5
                        END + 
                        CASE 
                            WHEN COALESCE(L1.CSN - COALESCE(L2.CSN, P.CSN_Truoc), L1.CSN) = 0 THEN L1.CSN * 15
                            ELSE (L1.CSN - COALESCE(L2.CSN, P.CSN_Truoc)) * 15
                        END AS TỔNG 
                FROM 
                    HOP_DONG_THUE hdt
                JOIN 
                    LatestMonths AS L1 ON hdt.MaHDT = L1.MaHDT AND L1.RowNum = 1
                LEFT JOIN 
                    LatestMonths AS L2 ON hdt.MaHDT = L2.MaHDT AND L2.RowNum = 2
                LEFT JOIN 
                    PreviousMonth AS P ON hdt.MaHDT = P.MaHDT
                JOIN 
                    PHONG phong ON hdt.MaPhong = phong.MaPhong
                JOIN 
                    KHACHHANG AS kh ON kh.MaKH = hdt.MaKH 
                WHERE 
                    hdt.MaHDT = @MaHDT;";



            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaHDT", MaHDT);

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
            MessageBox.Show("Xoá thành công");
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
            MessageBox.Show("Chi tiết hóa đơn đã được cập nhật thành công!");
            func.LoadOrderDetail(dataGridViewLoadOrderDetail, conn, "SELECT * FROM CHI_TIET_HD");
        }
    }
}
