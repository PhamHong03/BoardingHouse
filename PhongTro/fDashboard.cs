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
        //public fDashboard()
        //{
        //    InitializeComponent();
        //    //this.name = s;
        //}
        public fDashboard(string s) : this()
        {
            InitializeComponent();
            this.name = s;
            labelUsername.Text = s;
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
    }
}
