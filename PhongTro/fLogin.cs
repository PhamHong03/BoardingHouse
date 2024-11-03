using Microsoft.Data.SqlClient;

namespace PhongTro
{
    public partial class fLogin : Form
    {
        SqlConnection conn = new SqlConnection();

        Function func = new Function();
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được trống");
            }
            //else if (username != "select USERNAME from ACCOUNT where USERNAME = '"+username+"'" || password != "select PASSWORD from ACCOUNT where PASSWORD = '" + password + "'")
            //{
            //    labelError.Visible = true;
            //}
            else
            {
                string sql = "select * from ACCOUNT where USERNAME = '" + username + "' AND PASSWORD = '" + password + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    labelError.Visible = false;
                    fDashboard fDashboard = new fDashboard(txtUserName.Text );
                    this.Hide();
                    fDashboard.Show();
                    //this.Show();
                    //fDashboard.FormClosed += (s, args) => this.Close();
                }
                reader.Close();
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            func.Connect(conn);
        }
    }
}
