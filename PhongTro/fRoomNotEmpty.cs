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

namespace PhongTro
{
    public partial class fRoomNotEmpty : Form
    {
        SqlConnection conn = new SqlConnection();

        Function func = new Function();
        public fRoomNotEmpty()
        {
            InitializeComponent();
        }

        private void fRoomNotEmpty_Load(object sender, EventArgs e)
        {
            func.Connect(conn);
            string query = "SELECT P.MaPhong, P.TenPhong, P.Gia, P.TrangThai, LP.TenLoai AS 'TENLOAI' FROM PHONG P JOIN LOAIPHONG LP ON P.MaLoai = LP.MaLoai where TrangThai = N'Đang ở'";
            //func.LoadDataGridView(dataGridViewLoadRoom, conn, "SELECT * FROM PHONG");

            func.LoadRoom(dataGridView1, conn, query);
        }
    }
}
