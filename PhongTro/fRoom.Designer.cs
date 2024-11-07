namespace PhongTro
{
    partial class fRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRoom));
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox3 = new TextBox();
            panel2 = new Panel();
            dataGridViewLoadRoom = new DataGridView();
            label6 = new Label();
            panel1 = new Panel();
            btnResetRoom = new Button();
            btnSaveRoom = new Button();
            btnDeleteRoom = new Button();
            btnEditRoom = new Button();
            btnAddRoom = new Button();
            comboBoxLoadPriceRoom = new ComboBox();
            label5 = new Label();
            comboBoxLoadStatusRoom = new ComboBox();
            label4 = new Label();
            comboBoxLoadTypeRoom = new ComboBox();
            label3 = new Label();
            txtNameRoom = new TextBox();
            label2 = new Label();
            txtIdRoom = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadRoom).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LavenderBlush;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(1, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1174, 777);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phòng ";
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1012, 46);
            button1.Name = "button1";
            button1.Size = new Size(153, 56);
            button1.TabIndex = 11;
            button1.Text = "Tìm kiếm ";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBox3.Location = new Point(688, 46);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Nhập từ khóa tìm kiếm ";
            textBox3.Size = new Size(318, 56);
            textBox3.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(dataGridViewLoadRoom);
            panel2.Controls.Add(label6);
            panel2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            panel2.Location = new Point(3, 320);
            panel2.Name = "panel2";
            panel2.Size = new Size(1174, 451);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridViewLoadRoom
            // 
            dataGridViewLoadRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoadRoom.BackgroundColor = Color.AliceBlue;
            dataGridViewLoadRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoadRoom.Location = new Point(6, 41);
            dataGridViewLoadRoom.Name = "dataGridViewLoadRoom";
            dataGridViewLoadRoom.RowHeadersWidth = 51;
            dataGridViewLoadRoom.Size = new Size(1162, 407);
            dataGridViewLoadRoom.TabIndex = 18;
            dataGridViewLoadRoom.CellClick += dataGridViewLoadRoom_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label6.Location = new Point(6, 0);
            label6.Name = "label6";
            label6.Size = new Size(179, 25);
            label6.TabIndex = 17;
            label6.Text = "* Danh sách phòng ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnResetRoom);
            panel1.Controls.Add(btnSaveRoom);
            panel1.Controls.Add(btnDeleteRoom);
            panel1.Controls.Add(btnEditRoom);
            panel1.Controls.Add(btnAddRoom);
            panel1.Controls.Add(comboBoxLoadPriceRoom);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBoxLoadStatusRoom);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxLoadTypeRoom);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNameRoom);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtIdRoom);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 199);
            panel1.TabIndex = 0;
            // 
            // btnResetRoom
            // 
            btnResetRoom.BackColor = Color.AliceBlue;
            btnResetRoom.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnResetRoom.ImageAlign = ContentAlignment.MiddleLeft;
            btnResetRoom.Location = new Point(1009, 128);
            btnResetRoom.Name = "btnResetRoom";
            btnResetRoom.Size = new Size(125, 56);
            btnResetRoom.TabIndex = 16;
            btnResetRoom.Text = "Đặt lại ";
            btnResetRoom.UseVisualStyleBackColor = false;
            btnResetRoom.Click += btnResetRoom_Click;
            // 
            // btnSaveRoom
            // 
            btnSaveRoom.BackColor = Color.AliceBlue;
            btnSaveRoom.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSaveRoom.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveRoom.Location = new Point(617, 128);
            btnSaveRoom.Name = "btnSaveRoom";
            btnSaveRoom.Size = new Size(114, 56);
            btnSaveRoom.TabIndex = 15;
            btnSaveRoom.Text = "Lưu ";
            btnSaveRoom.UseVisualStyleBackColor = false;
            btnSaveRoom.Click += btnSaveRoom_Click;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.BackColor = Color.AliceBlue;
            btnDeleteRoom.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDeleteRoom.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteRoom.Location = new Point(749, 128);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(114, 56);
            btnDeleteRoom.TabIndex = 14;
            btnDeleteRoom.Text = "Xóa ";
            btnDeleteRoom.UseVisualStyleBackColor = false;
            btnDeleteRoom.Click += btnDeleteRoom_Click;
            // 
            // btnEditRoom
            // 
            btnEditRoom.BackColor = Color.AliceBlue;
            btnEditRoom.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnEditRoom.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditRoom.Location = new Point(879, 128);
            btnEditRoom.Name = "btnEditRoom";
            btnEditRoom.Size = new Size(114, 56);
            btnEditRoom.TabIndex = 13;
            btnEditRoom.Text = "Sửa ";
            btnEditRoom.UseVisualStyleBackColor = false;
            btnEditRoom.Click += btnEditRoom_Click;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.AliceBlue;
            btnAddRoom.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnAddRoom.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddRoom.Location = new Point(481, 128);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(114, 56);
            btnAddRoom.TabIndex = 12;
            btnAddRoom.Text = "Thêm ";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // comboBoxLoadPriceRoom
            // 
            comboBoxLoadPriceRoom.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxLoadPriceRoom.FormattingEnabled = true;
            comboBoxLoadPriceRoom.Items.AddRange(new object[] { "1200000", "900000" });
            comboBoxLoadPriceRoom.Location = new Point(935, 29);
            comboBoxLoadPriceRoom.Name = "comboBoxLoadPriceRoom";
            comboBoxLoadPriceRoom.Size = new Size(199, 31);
            comboBoxLoadPriceRoom.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(852, 31);
            label5.Name = "label5";
            label5.Size = new Size(55, 28);
            label5.TabIndex = 8;
            label5.Text = "Giá: ";
            // 
            // comboBoxLoadStatusRoom
            // 
            comboBoxLoadStatusRoom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxLoadStatusRoom.FormattingEnabled = true;
            comboBoxLoadStatusRoom.Items.AddRange(new object[] { "Đang ở", "Trống " });
            comboBoxLoadStatusRoom.Location = new Point(590, 31);
            comboBoxLoadStatusRoom.Name = "comboBoxLoadStatusRoom";
            comboBoxLoadStatusRoom.Size = new Size(223, 28);
            comboBoxLoadStatusRoom.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(461, 31);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 6;
            label4.Text = "Trạng thái: ";
            // 
            // comboBoxLoadTypeRoom
            // 
            comboBoxLoadTypeRoom.DisplayMember = "TenLoai";
            comboBoxLoadTypeRoom.Font = new Font("Segoe UI", 10.2F);
            comboBoxLoadTypeRoom.FormattingEnabled = true;
            comboBoxLoadTypeRoom.Location = new Point(162, 145);
            comboBoxLoadTypeRoom.Name = "comboBoxLoadTypeRoom";
            comboBoxLoadTypeRoom.Size = new Size(256, 31);
            comboBoxLoadTypeRoom.TabIndex = 5;
            comboBoxLoadTypeRoom.ValueMember = "MaLoai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(17, 153);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 4;
            label3.Text = "Loại phòng: ";
            // 
            // txtNameRoom
            // 
            txtNameRoom.Font = new Font("Segoe UI", 10.2F);
            txtNameRoom.Location = new Point(162, 86);
            txtNameRoom.Name = "txtNameRoom";
            txtNameRoom.Size = new Size(256, 30);
            txtNameRoom.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(17, 88);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên phòng: ";
            // 
            // txtIdRoom
            // 
            txtIdRoom.Font = new Font("Segoe UI", 10.2F);
            txtIdRoom.Location = new Point(162, 29);
            txtIdRoom.Name = "txtIdRoom";
            txtIdRoom.ReadOnly = true;
            txtIdRoom.Size = new Size(256, 30);
            txtIdRoom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã phòng: ";
            // 
            // fRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 783);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fRoom";
            Text = "fRoom";
            Load += fRoom_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadRoom).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtNameRoom;
        private Label label2;
        private TextBox txtIdRoom;
        private Label label1;
        private ComboBox comboBoxLoadStatusRoom;
        private Label label4;
        private ComboBox comboBoxLoadTypeRoom;
        private Label label3;
        private ComboBox comboBoxLoadPriceRoom;
        private Label label5;
        private Button button1;
        private TextBox textBox3;
        private Button btnResetRoom;
        private Button btnSaveRoom;
        private Button btnDeleteRoom;
        private Button btnEditRoom;
        private Button btnAddRoom;
        private DataGridView dataGridViewLoadRoom;
        private Label label6;
    }
}