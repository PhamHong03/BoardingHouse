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
    public partial class fAccount : Form
    {
        SqlConnection conn = new SqlConnection();

        Function func = new Function();
        public fAccount()
        {
            InitializeComponent();
        }

        private void fAccount_Load(object sender, EventArgs e)
        {

        }

        private void fAccount_Load_1(object sender, EventArgs e)
        {
        }

        private void fAccount_Load_2(object sender, EventArgs e)
        {


            func.Connect(conn);

            func.LoadAccount(dataGridViewLoadlistAccount, conn, "SELECT * FROM ACCOUNT");
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string username = txtUserNameAccount.Text;
            string password = txtPasswordAccount.Text;
            string displayname = txtDisplayNameAccount.Text;
            string role = comboBox1.Text;

            string sql = "INSERT INTO ACCOUNT VALUES ('" + username + "', N'" + displayname + "', '" + password + "', N'" + role + "')";

            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OKCancel);

            func.LoadAccount(dataGridViewLoadlistAccount, conn, "SELECT * FROM ACCOUNT");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = txtUserNameAccount.Text;

            string sql = "delete from ACCOUNT where USERNAME = '" + username + "'";

            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OKCancel);

            func.LoadAccount(dataGridViewLoadlistAccount, conn, "SELECT * FROM ACCOUNT");
        }

        private void dataGridViewLoadlistAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserNameAccount.Text = dataGridViewLoadlistAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDisplayNameAccount.Text = dataGridViewLoadlistAccount.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPasswordAccount.Text = dataGridViewLoadlistAccount.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.Text = dataGridViewLoadlistAccount.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string username = txtUserNameAccount.Text;
            string password = txtPasswordAccount.Text;
            string displayname = txtDisplayNameAccount.Text;
            string role = comboBox1.Text;

            string sql = "UPDATE ACCOUNT SET DISPLAYNAME = '" + displayname + "', PASSWORD = '" + password + "', ROLE = '" + role + "' WHERE USERNAME = '" + username + "'";

            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Sửa tài khoản thành công", "Thông báo", MessageBoxButtons.OKCancel);

            func.LoadAccount(dataGridViewLoadlistAccount, conn, "SELECT * FROM ACCOUNT");

        }

        private void btnResetAccount_Click(object sender, EventArgs e)
        {
            txtUserNameAccount.Clear();
            txtDisplayNameAccount.Clear();
            txtPasswordAccount.Clear();

        }

        private void btnPrintAccount_Click(object sender, EventArgs e)
        {
            fPrintAccount fPrintRoom = new fPrintAccount();
            Point pictureBoxLocation = groupBox.PointToScreen(Point.Empty);
            fPrintRoom.StartPosition = FormStartPosition.Manual;
            fPrintRoom.Location = pictureBoxLocation;
            fPrintRoom.Show();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tukhoa = txtSearchAccount.Text;
                string sql = "SELECT * FROM ACCOUNT WHERE DISPLAYNAME LIKE '%" + tukhoa + "%'";

                func.LoadAccount(dataGridViewLoadlistAccount, conn, sql);
            }
        }
    }
}
