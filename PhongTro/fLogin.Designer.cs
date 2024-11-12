namespace PhongTro
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            labelError = new Label();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(180, 19);
            label1.Name = "label1";
            label1.Size = new Size(499, 32);
            label1.TabIndex = 0;
            label1.Text = "HỆ THỐNG NHÀ TRỌ QUY MÔ LỚN ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(171, 123);
            label2.Name = "label2";
            label2.Size = new Size(171, 19);
            label2.TabIndex = 1;
            label2.Text = "* Vui lòng đăng nhập :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(171, 164);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên đăng nhập: ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(171, 227);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu: ";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(340, 155);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(248, 34);
            txtUserName.TabIndex = 4;
            txtUserName.Text = "Admin";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(340, 218);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(248, 34);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "123";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LavenderBlush;
            btnLogin.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLogin.ForeColor = Color.DarkBlue;
            btnLogin.Location = new Point(317, 312);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(186, 61);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "ĐĂNG NHẬP ";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(227, 266);
            label5.Name = "label5";
            label5.Size = new Size(120, 19);
            label5.TabIndex = 7;
            label5.Text = "Quên mật khẩu ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(521, 348);
            label6.Name = "label6";
            label6.Size = new Size(163, 17);
            label6.TabIndex = 8;
            label6.Text = "Bạn chưa có tài khoản ?";
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(684, 333);
            button1.Name = "button1";
            button1.Size = new Size(104, 40);
            button1.TabIndex = 9;
            button1.Text = "Đăng ký ";
            button1.UseVisualStyleBackColor = false;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(193, 405);
            labelError.Name = "labelError";
            labelError.Size = new Size(411, 19);
            labelError.TabIndex = 14;
            labelError.Text = "*Tên đăng nhập hoặc mật khẩu sai  vui lòng kiểm tra lại ";
            labelError.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            linkLabel1.LinkColor = Color.DarkGreen;
            linkLabel1.Location = new Point(39, 382);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 19);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Hỗ trợ ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label7.ForeColor = Color.DarkSlateBlue;
            label7.Location = new Point(353, 66);
            label7.Name = "label7";
            label7.Size = new Size(105, 17);
            label7.TabIndex = 16;
            label7.Text = "(Quản trị viên )";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(linkLabel1);
            Controls.Add(labelError);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fLogin";
            Load += fLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label labelError;
        private LinkLabel linkLabel1;
        private Label label7;
    }
}
