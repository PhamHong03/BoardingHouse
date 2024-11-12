namespace PhongTro
{
    partial class fDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDashboard));
            panel1 = new Panel();
            labelUsername = new Label();
            btnExitDashboard = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btnAccount = new Button();
            btnReport = new Button();
            btnOrderDetail = new Button();
            btnContractMn = new Button();
            btnCustomerMn = new Button();
            btnRoomMn = new Button();
            panelBig = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(btnExitDashboard);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1518, 125);
            panel1.TabIndex = 0;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelUsername.ForeColor = Color.DarkBlue;
            labelUsername.Location = new Point(1263, 76);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(67, 26);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "label2";
            // 
            // btnExitDashboard
            // 
            btnExitDashboard.Image = (Image)resources.GetObject("btnExitDashboard.Image");
            btnExitDashboard.Location = new Point(1475, 0);
            btnExitDashboard.Name = "btnExitDashboard";
            btnExitDashboard.Size = new Size(40, 42);
            btnExitDashboard.TabIndex = 1;
            btnExitDashboard.UseVisualStyleBackColor = true;
            btnExitDashboard.Click += btnExitDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(367, 31);
            label1.Name = "label1";
            label1.Size = new Size(844, 42);
            label1.TabIndex = 0;
            label1.Text = "HỆ THỐNG QUẢN LÝ NHÀ TRỌ QUY MÔ LỚN ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(btnAccount);
            panel2.Controls.Add(btnReport);
            panel2.Controls.Add(btnOrderDetail);
            panel2.Controls.Add(btnContractMn);
            panel2.Controls.Add(btnCustomerMn);
            panel2.Controls.Add(btnRoomMn);
            panel2.Location = new Point(1, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 783);
            panel2.TabIndex = 1;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.AliceBlue;
            btnAccount.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnAccount.ForeColor = Color.MidnightBlue;
            btnAccount.Image = (Image)resources.GetObject("btnAccount.Image");
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(21, 405);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(300, 59);
            btnAccount.TabIndex = 5;
            btnAccount.Text = "Quản lý tài khoản ";
            btnAccount.TextAlign = ContentAlignment.MiddleRight;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.AliceBlue;
            btnReport.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnReport.ForeColor = Color.MidnightBlue;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(21, 328);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(300, 59);
            btnReport.TabIndex = 4;
            btnReport.Text = "Báo cáo thống kê ";
            btnReport.TextAlign = ContentAlignment.MiddleRight;
            btnReport.UseVisualStyleBackColor = false;
            // 
            // btnOrderDetail
            // 
            btnOrderDetail.BackColor = Color.AliceBlue;
            btnOrderDetail.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnOrderDetail.ForeColor = Color.MidnightBlue;
            btnOrderDetail.Image = (Image)resources.GetObject("btnOrderDetail.Image");
            btnOrderDetail.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrderDetail.Location = new Point(21, 248);
            btnOrderDetail.Name = "btnOrderDetail";
            btnOrderDetail.Size = new Size(300, 59);
            btnOrderDetail.TabIndex = 3;
            btnOrderDetail.Text = "Quản lý chi tiết HD ";
            btnOrderDetail.TextAlign = ContentAlignment.MiddleRight;
            btnOrderDetail.UseVisualStyleBackColor = false;
            btnOrderDetail.Click += btnOrderDetail_Click;
            // 
            // btnContractMn
            // 
            btnContractMn.BackColor = Color.AliceBlue;
            btnContractMn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnContractMn.ForeColor = Color.MidnightBlue;
            btnContractMn.Image = (Image)resources.GetObject("btnContractMn.Image");
            btnContractMn.ImageAlign = ContentAlignment.MiddleLeft;
            btnContractMn.Location = new Point(21, 171);
            btnContractMn.Name = "btnContractMn";
            btnContractMn.Size = new Size(300, 59);
            btnContractMn.TabIndex = 2;
            btnContractMn.Text = "Quản lý hợp đồng ";
            btnContractMn.TextAlign = ContentAlignment.MiddleRight;
            btnContractMn.UseVisualStyleBackColor = false;
            btnContractMn.Click += btnContractMn_Click;
            // 
            // btnCustomerMn
            // 
            btnCustomerMn.BackColor = Color.AliceBlue;
            btnCustomerMn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnCustomerMn.ForeColor = Color.MidnightBlue;
            btnCustomerMn.Image = (Image)resources.GetObject("btnCustomerMn.Image");
            btnCustomerMn.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomerMn.Location = new Point(21, 90);
            btnCustomerMn.Name = "btnCustomerMn";
            btnCustomerMn.Size = new Size(300, 59);
            btnCustomerMn.TabIndex = 1;
            btnCustomerMn.Text = "Quản lý người thuê ";
            btnCustomerMn.TextAlign = ContentAlignment.MiddleRight;
            btnCustomerMn.UseVisualStyleBackColor = false;
            btnCustomerMn.Click += btnCustomerMn_Click;
            // 
            // btnRoomMn
            // 
            btnRoomMn.BackColor = Color.AliceBlue;
            btnRoomMn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            btnRoomMn.ForeColor = Color.MidnightBlue;
            btnRoomMn.Image = (Image)resources.GetObject("btnRoomMn.Image");
            btnRoomMn.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoomMn.Location = new Point(21, 15);
            btnRoomMn.Name = "btnRoomMn";
            btnRoomMn.Size = new Size(300, 59);
            btnRoomMn.TabIndex = 0;
            btnRoomMn.Text = "Quản lý phòng ";
            btnRoomMn.UseVisualStyleBackColor = false;
            btnRoomMn.Click += btnRoomMn_Click;
            // 
            // panelBig
            // 
            panelBig.Location = new Point(341, 133);
            panelBig.Name = "panelBig";
            panelBig.Size = new Size(1175, 783);
            panelBig.TabIndex = 2;
            panelBig.Paint += panelBig_Paint;
            // 
            // fDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1520, 922);
            Controls.Add(panelBig);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnCustomerMn;
        private Button btnRoomMn;
        private Panel panelBig;
        private Button btnContractMn;
        private Button btnOrderDetail;
        private Button btnReport;
        private Button btnExitDashboard;
        private Label labelUsername;
        private Button btnAccount;
    }
}