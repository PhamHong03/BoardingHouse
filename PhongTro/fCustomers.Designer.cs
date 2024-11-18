namespace PhongTro
{
    partial class fCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCustomers));
            groupBox1 = new GroupBox();
            txtSearchCustomer = new TextBox();
            btnSearchCustomer = new Button();
            panel2 = new Panel();
            label1 = new Label();
            dataGridViewLoadCustomer = new DataGridView();
            panel1 = new Panel();
            btnAddCustomer = new Button();
            btnSaveCustomer = new Button();
            btnEditCustomer = new Button();
            btnDeleteCustomer = new Button();
            btnResetCustomer = new Button();
            btnExport = new Button();
            btnPrint = new Button();
            comboBoxLoadGender = new ComboBox();
            txtCccdCustomer = new TextBox();
            txtAddressCustomer = new TextBox();
            txtNameCustomer = new TextBox();
            txtPhoneCustomer = new TextBox();
            txtIdCustomer = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadCustomer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearchCustomer);
            groupBox1.Controls.Add(btnSearchCustomer);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = Color.DarkBlue;
            groupBox1.Location = new Point(0, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1154, 759);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng ";
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Font = new Font("Times New Roman", 12F);
            txtSearchCustomer.Location = new Point(689, 29);
            txtSearchCustomer.Multiline = true;
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.PlaceholderText = "Nhập tìm kiếm ";
            txtSearchCustomer.Size = new Size(277, 44);
            txtSearchCustomer.TabIndex = 18;
            txtSearchCustomer.KeyDown += txtSearchCustomer_KeyDown;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.BackColor = Color.LavenderBlush;
            btnSearchCustomer.Image = (Image)resources.GetObject("btnSearchCustomer.Image");
            btnSearchCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchCustomer.Location = new Point(981, 29);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(129, 44);
            btnSearchCustomer.TabIndex = 18;
            btnSearchCustomer.Text = "Tìm kiếm ";
            btnSearchCustomer.TextAlign = ContentAlignment.MiddleRight;
            btnSearchCustomer.UseVisualStyleBackColor = false;
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridViewLoadCustomer);
            panel2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(6, 315);
            panel2.Name = "panel2";
            panel2.Size = new Size(1124, 438);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 0;
            label1.Text = "* Danh sách khách hàng ";
            // 
            // dataGridViewLoadCustomer
            // 
            dataGridViewLoadCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoadCustomer.BackgroundColor = Color.LavenderBlush;
            dataGridViewLoadCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoadCustomer.Location = new Point(3, 44);
            dataGridViewLoadCustomer.Name = "dataGridViewLoadCustomer";
            dataGridViewLoadCustomer.RowHeadersWidth = 51;
            dataGridViewLoadCustomer.Size = new Size(1118, 391);
            dataGridViewLoadCustomer.TabIndex = 0;
            dataGridViewLoadCustomer.CellClick += dataGridViewLoadCustomer_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btnAddCustomer);
            panel1.Controls.Add(btnSaveCustomer);
            panel1.Controls.Add(btnEditCustomer);
            panel1.Controls.Add(btnDeleteCustomer);
            panel1.Controls.Add(btnResetCustomer);
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(comboBoxLoadGender);
            panel1.Controls.Add(txtCccdCustomer);
            panel1.Controls.Add(txtAddressCustomer);
            panel1.Controls.Add(txtNameCustomer);
            panel1.Controls.Add(txtPhoneCustomer);
            panel1.Controls.Add(txtIdCustomer);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124, 224);
            panel1.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.LavenderBlush;
            btnAddCustomer.Location = new Point(462, 162);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(92, 44);
            btnAddCustomer.TabIndex = 18;
            btnAddCustomer.Text = "Thêm ";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnSaveCustomer
            // 
            btnSaveCustomer.BackColor = Color.LavenderBlush;
            btnSaveCustomer.Location = new Point(604, 162);
            btnSaveCustomer.Name = "btnSaveCustomer";
            btnSaveCustomer.Size = new Size(92, 44);
            btnSaveCustomer.TabIndex = 17;
            btnSaveCustomer.Text = "Lưu";
            btnSaveCustomer.UseVisualStyleBackColor = false;
            btnSaveCustomer.Click += btnSaveCustomer_Click;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.BackColor = Color.LavenderBlush;
            btnEditCustomer.Location = new Point(741, 162);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(92, 44);
            btnEditCustomer.TabIndex = 16;
            btnEditCustomer.Text = "Sửa ";
            btnEditCustomer.UseVisualStyleBackColor = false;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.BackColor = Color.LavenderBlush;
            btnDeleteCustomer.Location = new Point(871, 162);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(92, 44);
            btnDeleteCustomer.TabIndex = 15;
            btnDeleteCustomer.Text = "Xóa ";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnResetCustomer
            // 
            btnResetCustomer.BackColor = Color.LavenderBlush;
            btnResetCustomer.Location = new Point(1003, 162);
            btnResetCustomer.Name = "btnResetCustomer";
            btnResetCustomer.Size = new Size(104, 44);
            btnResetCustomer.TabIndex = 14;
            btnResetCustomer.Text = "Đặt lại ";
            btnResetCustomer.UseVisualStyleBackColor = false;
            btnResetCustomer.Click += btnResetCustomer_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.LavenderBlush;
            btnExport.Location = new Point(128, 162);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(110, 44);
            btnExport.TabIndex = 13;
            btnExport.Text = "Xuất file";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.LavenderBlush;
            btnPrint.Location = new Point(16, 162);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(92, 44);
            btnPrint.TabIndex = 12;
            btnPrint.Text = "In file ";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // comboBoxLoadGender
            // 
            comboBoxLoadGender.Font = new Font("Times New Roman", 12F);
            comboBoxLoadGender.ForeColor = Color.MidnightBlue;
            comboBoxLoadGender.FormattingEnabled = true;
            comboBoxLoadGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBoxLoadGender.Location = new Point(937, 78);
            comboBoxLoadGender.Name = "comboBoxLoadGender";
            comboBoxLoadGender.Size = new Size(170, 30);
            comboBoxLoadGender.TabIndex = 11;
            // 
            // txtCccdCustomer
            // 
            txtCccdCustomer.Font = new Font("Times New Roman", 12F);
            txtCccdCustomer.ForeColor = Color.MidnightBlue;
            txtCccdCustomer.Location = new Point(886, 24);
            txtCccdCustomer.Name = "txtCccdCustomer";
            txtCccdCustomer.Size = new Size(221, 30);
            txtCccdCustomer.TabIndex = 10;
            // 
            // txtAddressCustomer
            // 
            txtAddressCustomer.Font = new Font("Times New Roman", 12F);
            txtAddressCustomer.ForeColor = Color.MidnightBlue;
            txtAddressCustomer.Location = new Point(560, 81);
            txtAddressCustomer.Name = "txtAddressCustomer";
            txtAddressCustomer.Size = new Size(221, 30);
            txtAddressCustomer.TabIndex = 9;
            // 
            // txtNameCustomer
            // 
            txtNameCustomer.Font = new Font("Times New Roman", 12F);
            txtNameCustomer.ForeColor = Color.MidnightBlue;
            txtNameCustomer.Location = new Point(169, 84);
            txtNameCustomer.Name = "txtNameCustomer";
            txtNameCustomer.Size = new Size(221, 30);
            txtNameCustomer.TabIndex = 8;
            // 
            // txtPhoneCustomer
            // 
            txtPhoneCustomer.Font = new Font("Times New Roman", 12F);
            txtPhoneCustomer.ForeColor = Color.MidnightBlue;
            txtPhoneCustomer.Location = new Point(560, 21);
            txtPhoneCustomer.Name = "txtPhoneCustomer";
            txtPhoneCustomer.Size = new Size(221, 30);
            txtPhoneCustomer.TabIndex = 7;
            // 
            // txtIdCustomer
            // 
            txtIdCustomer.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtIdCustomer.ForeColor = Color.MidnightBlue;
            txtIdCustomer.Location = new Point(169, 28);
            txtIdCustomer.Name = "txtIdCustomer";
            txtIdCustomer.ReadOnly = true;
            txtIdCustomer.Size = new Size(221, 30);
            txtIdCustomer.TabIndex = 6;
            txtIdCustomer.TextChanged += txtIdCustomer_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(807, 27);
            label7.Name = "label7";
            label7.Size = new Size(73, 23);
            label7.TabIndex = 5;
            label7.Text = "CCCD:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(807, 84);
            label6.Name = "label6";
            label6.Size = new Size(97, 23);
            label6.TabIndex = 4;
            label6.Text = "Giới tính: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(434, 88);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 3;
            label5.Text = "Nơi ở: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(424, 28);
            label4.Name = "label4";
            label4.Size = new Size(130, 23);
            label4.TabIndex = 2;
            label4.Text = "Số điện thoại: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(13, 91);
            label3.Name = "label3";
            label3.Size = new Size(154, 23);
            label3.TabIndex = 1;
            label3.Text = "Tên khách hàng: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(13, 28);
            label2.Name = "label2";
            label2.Size = new Size(150, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã khách hàng: ";
            // 
            // fCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 783);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fCustomers";
            Text = "fCustomers";
            Load += fCustomers_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadCustomer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridViewLoadCustomer;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSearchCustomer;
        private Button btnSaveCustomer;
        private Button btnEditCustomer;
        private Button btnDeleteCustomer;
        private Button btnResetCustomer;
        private Button btnExport;
        private Button btnPrint;
        private ComboBox comboBoxLoadGender;
        private TextBox txtCccdCustomer;
        private TextBox txtAddressCustomer;
        private TextBox txtNameCustomer;
        private TextBox txtPhoneCustomer;
        private TextBox txtIdCustomer;
        private Label label7;
        private Label label6;
        private TextBox txtSearchCustomer;
        private Button btnAddCustomer;
    }
}