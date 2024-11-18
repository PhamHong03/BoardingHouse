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
    public partial class fContractExpire : Form
    {
        SqlConnection conn = new SqlConnection();

        Function func = new Function();
        public fContractExpire()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fContractExpire_Load(object sender, EventArgs e)
        {
            func.Connect(conn);
            string query = "SELECT H.MaHDT, H.NGAY_THUE, H.THOI_HAN, H.NOI_DUNG, K.TenKH AS 'KH', P.TenPhong AS 'TEN PHONG' FROM HOP_DONG_THUE H JOIN KHACHHANG K ON H.MaKH = K.MaKH JOIN PHONG P ON H.MaPhong = P.MaPhong where THOI_HAN < GETDATE()";
            func.LoadContract(dataGridView1, conn, query);
        }
    }
}
