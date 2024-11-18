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
    public partial class fDashboard() : Form
    {
        public string name = "";
        public string displayname = "";
        public fDashboard(string s, string s1) : this()
        {
            InitializeComponent();
            //this.name = s;
            this.displayname = s1;
            labelUsername.Text = "Xin chào, " + s1 + "!";
        }

        private void btnRoomMn_Click(object sender, EventArgs e)
        {
            fRoom roomForm = new fRoom();
            Point pictureBoxLocation = panelBig.PointToScreen(Point.Empty);
            roomForm.StartPosition = FormStartPosition.Manual;
            roomForm.Location = pictureBoxLocation;
            roomForm.Show();
        }

        private void btnExitDashboard_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomerMn_Click(object sender, EventArgs e)
        {
            fCustomers roomForm = new fCustomers();
            Point pictureBoxLocation = panelBig.PointToScreen(Point.Empty);
            roomForm.StartPosition = FormStartPosition.Manual;
            roomForm.Location = pictureBoxLocation;
            roomForm.Show();
        }

        private void btnContractMn_Click(object sender, EventArgs e)
        {
            fContract roomForm = new fContract();
            Point pictureBoxLocation = panelBig.PointToScreen(Point.Empty);
            roomForm.StartPosition = FormStartPosition.Manual;
            roomForm.Location = pictureBoxLocation;
            roomForm.Show();
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            fOrderDetail roomForm = new fOrderDetail();
            Point pictureBoxLocation = panelBig.PointToScreen(Point.Empty);
            roomForm.StartPosition = FormStartPosition.Manual;
            roomForm.Location = pictureBoxLocation;
            roomForm.Show();
        }

        private void panelBig_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            fAccount roomForm = new fAccount();
            Point pictureBoxLocation = panelBig.PointToScreen(Point.Empty);
            roomForm.StartPosition = FormStartPosition.Manual;
            roomForm.Location = pictureBoxLocation;
            roomForm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            fReport2 roomForm = new fReport2();
            Point pictureBoxLocation = panelBig.PointToScreen(Point.Empty);
            roomForm.StartPosition = FormStartPosition.Manual;
            roomForm.Location = pictureBoxLocation;
            roomForm.Show();
        }
    }
}
