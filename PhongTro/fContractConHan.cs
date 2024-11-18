﻿using Microsoft.Data.SqlClient;
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
    public partial class fContractConHan : Form
    {
        SqlConnection conn = new SqlConnection();

        Function func = new Function();
        public fContractConHan()
        {
            InitializeComponent();
        }

        private void fContractConHan_Load(object sender, EventArgs e)
        {
            func.Connect(conn);
            string query = "SELECT H.MaHDT, H.NGAY_THUE, H.THOI_HAN, H.NOI_DUNG, K.TenKH AS 'KH', P.TenPhong AS 'TEN PHONG' FROM HOP_DONG_THUE H JOIN KHACHHANG K ON H.MaKH = K.MaKH JOIN PHONG P ON H.MaPhong = P.MaPhong WHERE THOI_HAN > GETDATE()";
            func.LoadContract(dataGridView1, conn, query);
        }
    }
}
