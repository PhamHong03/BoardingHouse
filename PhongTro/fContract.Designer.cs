namespace PhongTro
{
    partial class fContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fContract));
            panel1 = new Panel();
            dateTimePickerContractExpire = new DateTimePicker();
            btnExportContract = new Button();
            btnResetContract = new Button();
            btnDeleteContract = new Button();
            btnEditContract = new Button();
            btnPrintContract = new Button();
            btnSaveContract = new Button();
            btnAddCustomer = new Button();
            comboBoxLoadCustomer = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtContentContract = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dateTimePickerContract = new DateTimePicker();
            label2 = new Label();
            comboBoxLoadRoom = new ComboBox();
            label1 = new Label();
            txtIdContract = new TextBox();
            panel2 = new Panel();
            label7 = new Label();
            dataGridViewLoadContract = new DataGridView();
            groupBox1 = new GroupBox();
            txtSearchContract = new TextBox();
            button8 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadContract).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(dateTimePickerContractExpire);
            panel1.Controls.Add(btnExportContract);
            panel1.Controls.Add(btnResetContract);
            panel1.Controls.Add(btnDeleteContract);
            panel1.Controls.Add(btnEditContract);
            panel1.Controls.Add(btnPrintContract);
            panel1.Controls.Add(btnSaveContract);
            panel1.Controls.Add(btnAddCustomer);
            panel1.Controls.Add(comboBoxLoadCustomer);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtContentContract);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTimePickerContract);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxLoadRoom);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtIdContract);
            panel1.Location = new Point(10, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(1151, 199);
            panel1.TabIndex = 2;
            // 
            // dateTimePickerContractExpire
            // 
            dateTimePickerContractExpire.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dateTimePickerContractExpire.Location = new Point(864, 78);
            dateTimePickerContractExpire.Name = "dateTimePickerContractExpire";
            dateTimePickerContractExpire.Size = new Size(270, 27);
            dateTimePickerContractExpire.TabIndex = 19;
            // 
            // btnExportContract
            // 
            btnExportContract.BackColor = Color.AliceBlue;
            btnExportContract.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnExportContract.ForeColor = Color.MidnightBlue;
            btnExportContract.Location = new Point(154, 133);
            btnExportContract.Name = "btnExportContract";
            btnExportContract.Size = new Size(120, 49);
            btnExportContract.TabIndex = 18;
            btnExportContract.Text = "Xuất file";
            btnExportContract.UseVisualStyleBackColor = false;
            // 
            // btnResetContract
            // 
            btnResetContract.BackColor = Color.AliceBlue;
            btnResetContract.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnResetContract.ForeColor = Color.MidnightBlue;
            btnResetContract.Location = new Point(1021, 133);
            btnResetContract.Name = "btnResetContract";
            btnResetContract.Size = new Size(102, 49);
            btnResetContract.TabIndex = 17;
            btnResetContract.Text = "Đặt lại ";
            btnResetContract.UseVisualStyleBackColor = false;
            btnResetContract.Click += btnResetContract_Click;
            // 
            // btnDeleteContract
            // 
            btnDeleteContract.BackColor = Color.AliceBlue;
            btnDeleteContract.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDeleteContract.ForeColor = Color.MidnightBlue;
            btnDeleteContract.Location = new Point(907, 133);
            btnDeleteContract.Name = "btnDeleteContract";
            btnDeleteContract.Size = new Size(84, 49);
            btnDeleteContract.TabIndex = 16;
            btnDeleteContract.Text = "Xóa ";
            btnDeleteContract.UseVisualStyleBackColor = false;
            btnDeleteContract.Click += btnDeleteContract_Click;
            // 
            // btnEditContract
            // 
            btnEditContract.BackColor = Color.AliceBlue;
            btnEditContract.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnEditContract.ForeColor = Color.MidnightBlue;
            btnEditContract.Location = new Point(794, 133);
            btnEditContract.Name = "btnEditContract";
            btnEditContract.Size = new Size(84, 49);
            btnEditContract.TabIndex = 15;
            btnEditContract.Text = "Sửa ";
            btnEditContract.UseVisualStyleBackColor = false;
            btnEditContract.Click += btnEditContract_Click;
            // 
            // btnPrintContract
            // 
            btnPrintContract.BackColor = Color.AliceBlue;
            btnPrintContract.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnPrintContract.ForeColor = Color.MidnightBlue;
            btnPrintContract.Location = new Point(17, 133);
            btnPrintContract.Name = "btnPrintContract";
            btnPrintContract.Size = new Size(96, 49);
            btnPrintContract.TabIndex = 14;
            btnPrintContract.Text = "In file";
            btnPrintContract.UseVisualStyleBackColor = false;
            // 
            // btnSaveContract
            // 
            btnSaveContract.BackColor = Color.AliceBlue;
            btnSaveContract.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSaveContract.ForeColor = Color.MidnightBlue;
            btnSaveContract.Location = new Point(680, 133);
            btnSaveContract.Name = "btnSaveContract";
            btnSaveContract.Size = new Size(84, 49);
            btnSaveContract.TabIndex = 13;
            btnSaveContract.Text = "Lưu ";
            btnSaveContract.UseVisualStyleBackColor = false;
            btnSaveContract.Click += btnSaveContract_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.AliceBlue;
            btnAddCustomer.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnAddCustomer.ForeColor = Color.MidnightBlue;
            btnAddCustomer.Location = new Point(563, 133);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(84, 49);
            btnAddCustomer.TabIndex = 12;
            btnAddCustomer.Text = "Thêm";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // comboBoxLoadCustomer
            // 
            comboBoxLoadCustomer.DisplayMember = "TenKH";
            comboBoxLoadCustomer.Font = new Font("Times New Roman", 10.8F);
            comboBoxLoadCustomer.FormattingEnabled = true;
            comboBoxLoadCustomer.Location = new Point(504, 16);
            comboBoxLoadCustomer.Name = "comboBoxLoadCustomer";
            comboBoxLoadCustomer.Size = new Size(203, 28);
            comboBoxLoadCustomer.TabIndex = 11;
            comboBoxLoadCustomer.ValueMember = "MaKH";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(378, 73);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 10;
            label6.Text = "Phòng: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(378, 25);
            label5.Name = "label5";
            label5.Size = new Size(120, 23);
            label5.TabIndex = 9;
            label5.Text = "Khách hàng: ";
            // 
            // txtContentContract
            // 
            txtContentContract.Font = new Font("Times New Roman", 10.8F);
            txtContentContract.Location = new Point(154, 81);
            txtContentContract.Name = "txtContentContract";
            txtContentContract.Size = new Size(184, 28);
            txtContentContract.TabIndex = 1;
//            txtContentContract.TextChanged += txtContentContract_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(17, 82);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 8;
            label4.Text = "Nội dung: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(751, 81);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 7;
            label3.Text = "Thời hạn: ";
            // 
            // dateTimePickerContract
            // 
            dateTimePickerContract.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dateTimePickerContract.Location = new Point(864, 18);
            dateTimePickerContract.Name = "dateTimePickerContract";
            dateTimePickerContract.Size = new Size(270, 27);
            dateTimePickerContract.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(751, 22);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 5;
            label2.Text = "Ngày thuê: ";
            // 
            // comboBoxLoadRoom
            // 
            comboBoxLoadRoom.DisplayMember = "TenPhong";
            comboBoxLoadRoom.Font = new Font("Times New Roman", 10.8F);
            comboBoxLoadRoom.FormattingEnabled = true;
            comboBoxLoadRoom.Location = new Point(504, 76);
            comboBoxLoadRoom.Name = "comboBoxLoadRoom";
            comboBoxLoadRoom.Size = new Size(203, 28);
            comboBoxLoadRoom.TabIndex = 4;
            comboBoxLoadRoom.ValueMember = "MaPhong";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(17, 22);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 3;
            label1.Text = "Mã hợp đồng: ";
            // 
            // txtIdContract
            // 
            txtIdContract.Font = new Font("Times New Roman", 12F);
            txtIdContract.Location = new Point(154, 18);
            txtIdContract.Name = "txtIdContract";
            txtIdContract.ReadOnly = true;
            txtIdContract.Size = new Size(184, 30);
            txtIdContract.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dataGridViewLoadContract);
            panel2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(10, 312);
            panel2.Name = "panel2";
            panel2.Size = new Size(1154, 462);
            panel2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label7.Location = new Point(17, 18);
            label7.Name = "label7";
            label7.Size = new Size(202, 23);
            label7.TabIndex = 1;
            label7.Text = "* Danh sách hợp đồng ";
            // 
            // dataGridViewLoadContract
            // 
            dataGridViewLoadContract.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoadContract.BackgroundColor = Color.GhostWhite;
            dataGridViewLoadContract.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoadContract.Location = new Point(2, 44);
            dataGridViewLoadContract.Name = "dataGridViewLoadContract";
            dataGridViewLoadContract.RowHeadersWidth = 51;
            dataGridViewLoadContract.Size = new Size(1149, 413);
            dataGridViewLoadContract.TabIndex = 0;
            dataGridViewLoadContract.CellClick += dataGridViewLoadContract_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearchContract);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = Color.DarkBlue;
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1170, 780);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý hợp đồng thuê trọ ";
            // 
            // txtSearchContract
            // 
            txtSearchContract.Font = new Font("Times New Roman", 12F);
            txtSearchContract.Location = new Point(781, 52);
            txtSearchContract.Multiline = true;
            txtSearchContract.Name = "txtSearchContract";
            txtSearchContract.PlaceholderText = "Nhập tìm kiếm ";
            txtSearchContract.Size = new Size(251, 49);
            txtSearchContract.TabIndex = 19;
            // 
            // button8
            // 
            button8.BackColor = Color.AliceBlue;
            button8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button8.ForeColor = Color.MidnightBlue;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(1040, 52);
            button8.Name = "button8";
            button8.Size = new Size(124, 49);
            button8.TabIndex = 19;
            button8.Text = "Tìm kiếm ";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.UseVisualStyleBackColor = false;
            // 
            // fContract
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1176, 783);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fContract";
            Text = "fContract";
            Load += fContract_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadContract).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewLoadContract;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox comboBoxLoadRoom;
        private Label label1;
        private TextBox txtContentContract;
        private TextBox txtIdContract;
        private Label label3;
        private DateTimePicker dateTimePickerContract;
        private Label label4;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxLoadCustomer;
        private Button btnSaveContract;
        private Button btnAddCustomer;
        private Button btnExportContract;
        private Button btnResetContract;
        private Button btnDeleteContract;
        private Button btnEditContract;
        private Button btnPrintContract;
        private Button button8;
        private TextBox txtSearchContract;
        private Label label7;
        private DateTimePicker dateTimePickerContractExpire;
    }
}