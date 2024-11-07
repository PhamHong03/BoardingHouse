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
    public partial class fCustomers : Form
    {
        SqlConnection conn = new SqlConnection();

        Function func = new Function();


        public fCustomers()
        {
            InitializeComponent();
        }

        private void fCustomers_Load(object sender, EventArgs e)
        {
            func.Connect(conn);
            func.LoadCustomer(dataGridViewLoadCustomer, conn, "SELECT * FROM KHACHHANG");

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string max_ms = "select MAX(substring(MaKH, 2,5))+1 FROM KHACHHANG";
            SqlCommand cmd = new SqlCommand(max_ms, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int new_ms = int.Parse(reader[0].ToString());
                if (new_ms < 10)
                {
                    txtIdCustomer.Text = "K000" + new_ms;
                }
                else if (new_ms < 100)
                {
                    txtIdCustomer.Text = "K00" + new_ms;

                }
                else if (new_ms < 1000)
                {
                    txtIdCustomer.Text = "K0" + new_ms;

                }
                else
                {
                    MessageBox.Show("Reset Ma phong di pro");
                }
            }

            txtIdCustomer.Enabled = false;
            reader.Close();

        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            string id = txtIdCustomer.Text;
            string name = txtNameCustomer.Text;
            string phone = txtPhoneCustomer.Text;
            string address = txtAddressCustomer.Text;
            string gender = comboBoxLoadGender.Text;
            string cccd = txtCccdCustomer.Text;

            string sql = "INSERT INTO KHACHHANG VALUES ('" + id + "', N'" + name + "', '" + phone + "', N'" + address + "', N'" + gender + "', '" + cccd + "')";


            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm khách hàng thành công");
            func.LoadDataGridView(dataGridViewLoadCustomer, conn, "SELECT * FROM KHACHHANG");
        }
            
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            string id = txtIdCustomer.Text;
            string name = txtNameCustomer.Text;
            string phone = txtPhoneCustomer.Text;
            string address = txtAddressCustomer.Text;
            string gender = comboBoxLoadGender.Text;
            string cccd = txtCccdCustomer.Text;

            string sql = "UPDATE KHACHHANG SET TenKH =  N'" + name + "', SoDT = '" + phone + "', DiaChi = N'" + address + "', GioiTinh = N'" + gender + "', So_cccd = '" + cccd + "' WHERE MaKH = '" + id + "'";


            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật khách hàng thành công");
            func.LoadDataGridView(dataGridViewLoadCustomer, conn, "SELECT * FROM KHACHHANG");
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string id = txtIdCustomer.Text;

            string sql = "DELETE KHACHHANG WHERE MaKH = '" + id + "'";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Xóa khách hàng thành công");
            func.LoadDataGridView(dataGridViewLoadCustomer, conn, "SELECT * FROM KHACHHANG");
        }

        private void btnResetCustomer_Click(object sender, EventArgs e)
        {
            txtIdCustomer.Clear();
            txtNameCustomer.Clear();
            txtPhoneCustomer.Clear();
            txtAddressCustomer.Clear();
            txtCccdCustomer.Clear();
        }


        private void dataGridViewLoadCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCustomer.Text = dataGridViewLoadCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNameCustomer.Text = dataGridViewLoadCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPhoneCustomer.Text = dataGridViewLoadCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAddressCustomer.Text = dataGridViewLoadCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxLoadGender.Text = dataGridViewLoadCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCccdCustomer.Text = dataGridViewLoadCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void txtSearchCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tukhoa = txtSearchCustomer.Text;
                string sql = "SELECT * FROM KHACHHANG WHERE TenKH LIKE '%" + tukhoa + "%'";

                func.LoadDataGridView(dataGridViewLoadCustomer, conn, sql);
            }
        }
    }
}
