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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PhongTro
{
    public partial class fReport2 : Form
    {
        Function func = new Function();

        SqlConnection conn = new SqlConnection();
        public fReport2()
        {
            InitializeComponent();
        }

        private void fReport2_Load(object sender, EventArgs e)
        {
            func.Connect(conn);
            string sql = "SELECT COUNT(*) AS TongSoPhongTrong FROM PHONG WHERE TrangThai = N'Trống';";
            string sql1 = "SELECT COUNT(*) AS TongSoPhongDaThue FROM PHONG WHERE TrangThai = N'Đang ở';";
            string sql2 = "SELECT COUNT(*) AS TongSoHopDongConHan FROM HOP_DONG_THUE WHERE Thoi_han > GETDATE();";
            string sql3 = "SELECT COUNT(*) AS TongSoHopDongHetHan FROM HOP_DONG_THUE WHERE Thoi_han < GETDATE();";
            string sql4 = "SELECT COUNT(MaKH) as tong FROM KHACHHANG";

            try
            {
                SqlCommand comd = new SqlCommand(sql, conn);
                SqlDataReader reader = comd.ExecuteReader();
                if (reader.Read())
                {
                    label4.Text = reader["TongSoPhongTrong"].ToString();
                }
                reader.Close();

                SqlCommand comd1 = new SqlCommand(sql1, conn);
                SqlDataReader reader1 = comd1.ExecuteReader();
                if (reader1.Read())
                {
                    label5.Text = reader1["TongSoPhongDaThue"].ToString();
                }
                reader1.Close();

                SqlCommand comd2 = new SqlCommand(sql2, conn);
                SqlDataReader reader2 = comd2.ExecuteReader();
                if (reader2.Read())
                {
                    label8.Text = reader2["TongSoHopDongConHan"].ToString();
                }
                reader2.Close();

                SqlCommand comd3 = new SqlCommand(sql3, conn);
                SqlDataReader reader3 = comd3.ExecuteReader();
                if (reader3.Read())
                {
                    label10.Text = reader3["TongSoHopDongHetHan"].ToString();
                }
                reader3.Close();

                SqlCommand comd4 = new SqlCommand(sql4, conn);
                SqlDataReader reader4 = comd4.ExecuteReader();
                if (reader4.Read())
                {
                    label3.Text = reader4["tong"].ToString();
                }
                reader4.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {
            fRoomEmpty roomForm = new fRoomEmpty();
            Point pictureBoxLocation = panelBig.PointToScreen(Point.Empty);
            roomForm.StartPosition = FormStartPosition.Manual;
            roomForm.Location = pictureBoxLocation;
            roomForm.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            fRoomNotEmpty roomForm = new fRoomNotEmpty();
            Point pictureBoxLocation = panelBig.PointToScreen(Point.Empty);
            roomForm.StartPosition = FormStartPosition.Manual;
            roomForm.Location = pictureBoxLocation;
            roomForm.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            fPrintCustomer fPrintRoom = new fPrintCustomer();
            Point pictureBoxLocation = panelBig.PointToScreen(Point.Empty);
            fPrintRoom.StartPosition = FormStartPosition.Manual;
            fPrintRoom.Location = pictureBoxLocation;
            fPrintRoom.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            fContractConHan fPrintRoom = new fContractConHan();
            Point pictureBoxLocation = panelBig.PointToScreen(Point.Empty);
            fPrintRoom.StartPosition = FormStartPosition.Manual;
            fPrintRoom.Location = pictureBoxLocation;
            fPrintRoom.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            fContractExpire fPrintRoom = new fContractExpire();
            Point pictureBoxLocation = panelBig.PointToScreen(Point.Empty);
            fPrintRoom.StartPosition = FormStartPosition.Manual;
            fPrintRoom.Location = pictureBoxLocation;
            fPrintRoom.Show();
        }

        private void panelBig_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
