namespace PhongTro
{
    partial class fAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAccount));
            groupBox = new GroupBox();
            button1 = new Button();
            dataGridViewLoadlistAccount = new DataGridView();
            textBox4 = new TextBox();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            btnDeleteAccount = new Button();
            btnPrintAccount = new Button();
            btnResetAccount = new Button();
            btnEditAccount = new Button();
            btnAddAccount = new Button();
            txtPasswordAccount = new TextBox();
            label1 = new Label();
            txtDisplayNameAccount = new TextBox();
            label2 = new Label();
            txtUserNameAccount = new TextBox();
            label3 = new Label();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadlistAccount).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.White;
            groupBox.Controls.Add(button1);
            groupBox.Controls.Add(dataGridViewLoadlistAccount);
            groupBox.Controls.Add(textBox4);
            groupBox.Controls.Add(panel1);
            groupBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            groupBox.ForeColor = Color.DarkBlue;
            groupBox.Location = new Point(7, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(1165, 769);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Quản lý thông tin tài khoản ";
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1005, 50);
            button1.Name = "button1";
            button1.Size = new Size(153, 56);
            button1.TabIndex = 13;
            button1.Text = "Tìm kiếm ";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewLoadlistAccount
            // 
            dataGridViewLoadlistAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoadlistAccount.BackgroundColor = Color.AliceBlue;
            dataGridViewLoadlistAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoadlistAccount.Location = new Point(2, 295);
            dataGridViewLoadlistAccount.Name = "dataGridViewLoadlistAccount";
            dataGridViewLoadlistAccount.RowHeadersWidth = 51;
            dataGridViewLoadlistAccount.Size = new Size(1154, 468);
            dataGridViewLoadlistAccount.TabIndex = 0;
            dataGridViewLoadlistAccount.CellClick += dataGridViewLoadlistAccount_CellClick;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox4.Location = new Point(681, 50);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Nhập từ khóa tìm kiếm ";
            textBox4.Size = new Size(318, 56);
            textBox4.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnDeleteAccount);
            panel1.Controls.Add(btnPrintAccount);
            panel1.Controls.Add(btnResetAccount);
            panel1.Controls.Add(btnEditAccount);
            panel1.Controls.Add(btnAddAccount);
            panel1.Controls.Add(txtPasswordAccount);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtDisplayNameAccount);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUserNameAccount);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(4, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(1154, 172);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Quản trị viên", "Thành viên mới" });
            comboBox1.Location = new Point(544, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 30);
            comboBox1.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(427, 36);
            label4.Name = "label4";
            label4.Size = new Size(85, 26);
            label4.TabIndex = 19;
            label4.Text = "Vai trò: ";
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = Color.AliceBlue;
            btnDeleteAccount.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnDeleteAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteAccount.Location = new Point(875, 25);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(114, 47);
            btnDeleteAccount.TabIndex = 18;
            btnDeleteAccount.Text = "Xóa ";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnPrintAccount
            // 
            btnPrintAccount.BackColor = Color.AliceBlue;
            btnPrintAccount.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnPrintAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrintAccount.Location = new Point(1016, 25);
            btnPrintAccount.Name = "btnPrintAccount";
            btnPrintAccount.Size = new Size(114, 47);
            btnPrintAccount.TabIndex = 17;
            btnPrintAccount.Text = "In";
            btnPrintAccount.UseVisualStyleBackColor = false;
            btnPrintAccount.Click += btnPrintAccount_Click;
            // 
            // btnResetAccount
            // 
            btnResetAccount.BackColor = Color.AliceBlue;
            btnResetAccount.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnResetAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnResetAccount.Location = new Point(1016, 105);
            btnResetAccount.Name = "btnResetAccount";
            btnResetAccount.Size = new Size(114, 47);
            btnResetAccount.TabIndex = 16;
            btnResetAccount.Text = "Đặt lại ";
            btnResetAccount.UseVisualStyleBackColor = false;
            btnResetAccount.Click += btnResetAccount_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.BackColor = Color.AliceBlue;
            btnEditAccount.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnEditAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditAccount.Location = new Point(875, 105);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(114, 47);
            btnEditAccount.TabIndex = 15;
            btnEditAccount.Text = "Sửa ";
            btnEditAccount.UseVisualStyleBackColor = false;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = Color.AliceBlue;
            btnAddAccount.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnAddAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddAccount.Location = new Point(735, 105);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(114, 47);
            btnAddAccount.TabIndex = 14;
            btnAddAccount.Text = "Thêm ";
            btnAddAccount.UseVisualStyleBackColor = false;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // txtPasswordAccount
            // 
            txtPasswordAccount.Location = new Point(544, 114);
            txtPasswordAccount.Name = "txtPasswordAccount";
            txtPasswordAccount.Size = new Size(165, 30);
            txtPasswordAccount.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(23, 39);
            label1.Name = "label1";
            label1.Size = new Size(152, 26);
            label1.TabIndex = 1;
            label1.Text = "Tên tài khoản: ";
            // 
            // txtDisplayNameAccount
            // 
            txtDisplayNameAccount.Location = new Point(199, 108);
            txtDisplayNameAccount.Name = "txtDisplayNameAccount";
            txtDisplayNameAccount.Size = new Size(191, 30);
            txtDisplayNameAccount.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(23, 108);
            label2.Name = "label2";
            label2.Size = new Size(136, 26);
            label2.TabIndex = 2;
            label2.Text = "Tên hiển thị: ";
            // 
            // txtUserNameAccount
            // 
            txtUserNameAccount.Location = new Point(199, 31);
            txtUserNameAccount.Name = "txtUserNameAccount";
            txtUserNameAccount.Size = new Size(191, 30);
            txtUserNameAccount.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(427, 116);
            label3.Name = "label3";
            label3.Size = new Size(111, 26);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu: ";
            // 
            // fAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1175, 783);
            Controls.Add(groupBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fAccount";
            Text = "fAccount";
            Load += fAccount_Load_2;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadlistAccount).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private TextBox txtPasswordAccount;
        private TextBox txtDisplayNameAccount;
        private TextBox txtUserNameAccount;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewLoadlistAccount;
        private Panel panel1;
        private Button button1;
        private TextBox textBox4;
        private Button btnDeleteAccount;
        private Button btnPrintAccount;
        private Button btnResetAccount;
        private Button btnEditAccount;
        private Button btnAddAccount;
        private ComboBox comboBox1;
        private Label label4;
    }
}