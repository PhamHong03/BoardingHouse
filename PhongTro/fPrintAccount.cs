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
    public partial class fPrintAccount : Form
    {
        SqlConnection conn = new SqlConnection();

        Function func = new Function();
        public fPrintAccount()
        {
            InitializeComponent();
        }

        private void fPrintAccount_Load(object sender, EventArgs e)
        {
            func.Connect(conn);

            func.LoadAccount(dataGridView1, conn, "SELECT * FROM ACCOUNT");
        }
    }
}
