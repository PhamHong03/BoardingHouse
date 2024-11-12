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
using System.Xml.Linq;

namespace PhongTro
{
    public partial class fRoom : Form
    {
        SqlConnection conn = new SqlConnection();

        Function func = new Function();
        public fRoom()
        {
            InitializeComponent();
        }

        private void fRoom_Load_1(object sender, EventArgs e)
        {
            func.Connect(conn);
            func.LoadComBoBox("SELECT * FROM LOAIPHONG", conn, comboBoxLoadTypeRoom, comboBoxLoadTypeRoom.DisplayMember, comboBoxLoadTypeRoom.ValueMember);

            string query = "SELECT P.MaPhong, P.TenPhong, P.Gia, P.TrangThai, LP.TenLoai AS 'TENLOAI' FROM PHONG P JOIN LOAIPHONG LP ON P.MaLoai = LP.MaLoai";
            //func.LoadDataGridView(dataGridViewLoadRoom, conn, "SELECT * FROM PHONG");

            func.LoadRoom(dataGridViewLoadRoom, conn, query);
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string max_ms = "select MAX(substring(MaPhong, 2,5))+1 FROM PHONG";
            SqlCommand cmd = new SqlCommand(max_ms, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int new_ms = int.Parse(reader[0].ToString());
                if (new_ms < 10)
                {
                    txtIdRoom.Text = "P000" + new_ms;
                }
                else if (new_ms < 100)
                {
                    txtIdRoom.Text = "P00" + new_ms;

                }
                else if (new_ms < 1000)
                {
                    txtIdRoom.Text = "P0" + new_ms;

                }
                else
                {
                    MessageBox.Show("Reset Ma phong di pro");
                }
            }

            txtIdRoom.Enabled = false;
            reader.Close();

        }

        private void btnSaveRoom_Click(object sender, EventArgs e)
        {
            string id = txtIdRoom.Text;
            string name = txtNameRoom.Text;
            float price = float.Parse(comboBoxLoadPriceRoom.Text);
            string status = comboBoxLoadStatusRoom.Text;
            string type = comboBoxLoadTypeRoom.SelectedValue.ToString();

            string sql = "INSERT INTO PHONG VALUES ('" + id + "', N'" + name + "', '" + price + "', N'" + status + "', '" + type + "')";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm phòng thành công");
            string query = "SELECT P.MaPhong, P.TenPhong, P.Gia, P.TrangThai, LP.TenLoai AS 'TENLOAI' FROM PHONG P JOIN LOAIPHONG LP ON P.MaLoai = LP.MaLoai";
            //func.LoadDataGridView(dataGridViewLoadRoom, conn, "SELECT * FROM PHONG");

            func.LoadRoom(dataGridViewLoadRoom, conn, query);
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            string maPhong = txtIdRoom.Text;
            string tenPhong = txtNameRoom.Text;
            string status = comboBoxLoadStatusRoom.Text;
            float price = float.Parse(comboBoxLoadPriceRoom.Text);
            string type = comboBoxLoadTypeRoom.SelectedValue.ToString();

            string sql = "UPDATE dbo.PHONG SET TenPhong = N'" + tenPhong + "', Gia = " + price + ", TrangThai = N'" + status + "', MaLoai = '" + type + "' WHERE MaPhong = '" + maPhong + "' ";
            //MessageBox.Show(sql);

            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Cập nhật phòng thành công");
            string query = "SELECT P.MaPhong, P.TenPhong, P.Gia, P.TrangThai, LP.TenLoai AS 'TENLOAI' FROM PHONG P JOIN LOAIPHONG LP ON P.MaLoai = LP.MaLoai";
            //func.LoadDataGridView(dataGridViewLoadRoom, conn, "SELECT * FROM PHONG");

            func.LoadRoom(dataGridViewLoadRoom, conn, query);

        }

        private void btnResetRoom_Click(object sender, EventArgs e)
        {
            txtIdRoom.Clear();
            txtNameRoom.Clear();
        }

        private void dataGridViewLoadRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdRoom.Text = dataGridViewLoadRoom.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNameRoom.Text = dataGridViewLoadRoom.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxLoadPriceRoom.Text = dataGridViewLoadRoom.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxLoadStatusRoom.Text = dataGridViewLoadRoom.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxLoadTypeRoom.Text = dataGridViewLoadRoom.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            string id = txtIdRoom.Text;

            string sql = "DELETE FROM PHONG WHERE MaPhong = '" + id + "'";
            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Xóa phòng thành công");
            string query = "SELECT P.MaPhong, P.TenPhong, P.Gia, P.TrangThai, LP.TenLoai AS 'TENLOAI' FROM PHONG P JOIN LOAIPHONG LP ON P.MaLoai = LP.MaLoai";
            //func.LoadDataGridView(dataGridViewLoadRoom, conn, "SELECT * FROM PHONG");

            func.LoadRoom(dataGridViewLoadRoom, conn, query);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fPrintRoom fPrintRoom = new fPrintRoom();
            Point pictureBoxLocation = groupBox1.PointToScreen(Point.Empty);
            fPrintRoom.StartPosition = FormStartPosition.Manual;
            fPrintRoom.Location = pictureBoxLocation;
            fPrintRoom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
