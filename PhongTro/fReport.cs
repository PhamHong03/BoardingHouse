using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;


namespace PhongTro
{
    public partial class fReport : Form
    {
        SqlConnection conn = new SqlConnection();

        Function func = new Function();
        public fReport()
        {
            InitializeComponent();
        }

        private void fReport_Load(object sender, EventArgs e)
        {
            func.Connect(conn);
            string sql = "SELECT COUNT(*) AS TongSoPhongTrong FROM PHONG WHERE TrangThai = N'Trống';";
            string sql1 = "SELECT COUNT(*) AS TongSoPhongDaThue FROM PHONG WHERE TrangThai = N'Đang ở';";
            string sql2 = "SELECT COUNT(*) AS TongSoHopDongConHan FROM HOP_DONG_THUE WHERE Thoi_han > GETDATE();";
            string sql3 = "SELECT COUNT(*) AS TongSoHopDongHetHan FROM HOP_DONG_THUE WHERE Thoi_han < GETDATE();";

            try
            {
                SqlCommand comd = new SqlCommand(sql, conn);
                SqlDataReader reader = comd.ExecuteReader();
                if (reader.Read())
                {
                    labelRoomEmpty.Text = reader["TongSoPhongTrong"].ToString();
                }
                reader.Close();

                SqlCommand comd1 = new SqlCommand(sql1, conn);
                SqlDataReader reader1 = comd1.ExecuteReader();
                if (reader1.Read())
                {
                    labelRoomFull.Text = reader1["TongSoPhongDaThue"].ToString();
                }
                reader1.Close();

                SqlCommand comd2 = new SqlCommand(sql2, conn);
                SqlDataReader reader2 = comd2.ExecuteReader();
                if (reader2.Read())
                {
                    labeLInContract.Text = reader2["TongSoHopDongConHan"].ToString();
                }
                reader2.Close();

                SqlCommand comd3 = new SqlCommand(sql3, conn);
                SqlDataReader reader3 = comd3.ExecuteReader();
                if (reader3.Read())
                {
                    labelOutContract.Text = reader3["TongSoHopDongHetHan"].ToString();
                }
                reader3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }


        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }


        private void labelDoanhthu_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }

}
