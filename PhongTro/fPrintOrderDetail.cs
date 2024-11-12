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
    public partial class fPrintOrderDetail : Form
    {
        SqlConnection conn = new SqlConnection();

        Function func = new Function();

        public fPrintOrderDetail()
        {
            InitializeComponent();
        }

        private void fPrintOrderDetail_Load(object sender, EventArgs e)
        {
            func.Connect(conn);
            func.LoadOrderDetail(dataGridView1, conn, "SELECT * FROM CHI_TIET_HD");

        }
    }
}
