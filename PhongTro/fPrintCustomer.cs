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
    public partial class fPrintCustomer : Form
    {
        SqlConnection conn = new SqlConnection();

        Function func = new Function();

        public fPrintCustomer()
        {
            InitializeComponent();
        }

        private void fPrintCustomer_Load(object sender, EventArgs e)
        {
            func.Connect(conn);
            string query = "SELECT * FROM KHACHHANG";

            func.LoadCustomer(dataGridView1, conn, query);      
        }
    }
}
