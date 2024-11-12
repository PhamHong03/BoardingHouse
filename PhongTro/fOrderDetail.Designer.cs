namespace PhongTro
{
    partial class fOrderDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOrderDetail));
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            dataGridViewLoadOrderDetail = new DataGridView();
            panel1 = new Panel();
            label7 = new Label();
            label3 = new Label();
            btnDetail = new Button();
            txtElectOrderDetail = new TextBox();
            txtWaterOrderDetail = new TextBox();
            comboBoxContract = new ComboBox();
            txtIdOrder = new TextBox();
            btnExportOrderDetail = new Button();
            label1 = new Label();
            btnResetOrderDetail = new Button();
            btnDeleteOrderDetail = new Button();
            label2 = new Label();
            btnEditOrderDetail = new Button();
            dateTimePickerDetailOrder = new DateTimePicker();
            btnPrintOrderDetail = new Button();
            btnSaveOrderDetail = new Button();
            label4 = new Label();
            btnAddOrderDetail = new Button();
            label5 = new Label();
            label6 = new Label();
            txtSearchContract = new TextBox();
            button8 = new Button();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadOrderDetail).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(txtSearchContract);
            groupBox1.Controls.Add(button8);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = Color.DarkBlue;
            groupBox1.Location = new Point(3, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1171, 771);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết hóa đơn ";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewLoadOrderDetail);
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(6, 276);
            panel2.Name = "panel2";
            panel2.Size = new Size(1159, 489);
            panel2.TabIndex = 23;
            // 
            // dataGridViewLoadOrderDetail
            // 
            dataGridViewLoadOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoadOrderDetail.BackgroundColor = Color.LavenderBlush;
            dataGridViewLoadOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoadOrderDetail.GridColor = SystemColors.ActiveBorder;
            dataGridViewLoadOrderDetail.Location = new Point(-3, 3);
            dataGridViewLoadOrderDetail.Name = "dataGridViewLoadOrderDetail";
            dataGridViewLoadOrderDetail.RowHeadersWidth = 51;
            dataGridViewLoadOrderDetail.Size = new Size(1159, 483);
            dataGridViewLoadOrderDetail.TabIndex = 0;
            dataGridViewLoadOrderDetail.CellClick += dataGridViewLoadOrderDetail_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnDetail);
            panel1.Controls.Add(txtElectOrderDetail);
            panel1.Controls.Add(txtWaterOrderDetail);
            panel1.Controls.Add(comboBoxContract);
            panel1.Controls.Add(txtIdOrder);
            panel1.Controls.Add(btnExportOrderDetail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnResetOrderDetail);
            panel1.Controls.Add(btnDeleteOrderDetail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnEditOrderDetail);
            panel1.Controls.Add(dateTimePickerDetailOrder);
            panel1.Controls.Add(btnPrintOrderDetail);
            panel1.Controls.Add(btnSaveOrderDetail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnAddOrderDetail);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(6, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(1159, 188);
            panel1.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label7.Location = new Point(682, 16);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 47;
            label7.Text = "Hệ số 15";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label3.Location = new Point(679, 79);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 46;
            label3.Text = "Hệ số 3.5";
            // 
            // btnDetail
            // 
            btnDetail.BackColor = Color.AliceBlue;
            btnDetail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDetail.ForeColor = Color.MidnightBlue;
            btnDetail.Location = new Point(314, 122);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(142, 49);
            btnDetail.TabIndex = 45;
            btnDetail.Text = "Xem chi tiết ";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // txtElectOrderDetail
            // 
            txtElectOrderDetail.Font = new Font("Times New Roman", 12F);
            txtElectOrderDetail.Location = new Point(519, 69);
            txtElectOrderDetail.Name = "txtElectOrderDetail";
            txtElectOrderDetail.Size = new Size(151, 30);
            txtElectOrderDetail.TabIndex = 44;
            // 
            // txtWaterOrderDetail
            // 
            txtWaterOrderDetail.Font = new Font("Times New Roman", 12F);
            txtWaterOrderDetail.Location = new Point(519, 10);
            txtWaterOrderDetail.Name = "txtWaterOrderDetail";
            txtWaterOrderDetail.Size = new Size(151, 30);
            txtWaterOrderDetail.TabIndex = 43;
            // 
            // comboBoxContract
            // 
            comboBoxContract.DisplayMember = "MaHDT";
            comboBoxContract.Font = new Font("Times New Roman", 10.8F);
            comboBoxContract.FormattingEnabled = true;
            comboBoxContract.Location = new Point(153, 69);
            comboBoxContract.Name = "comboBoxContract";
            comboBoxContract.Size = new Size(188, 28);
            comboBoxContract.TabIndex = 42;
            comboBoxContract.ValueMember = "MaHDT";
            comboBoxContract.SelectedIndexChanged += comboBoxContract_SelectedIndexChanged;
            // 
            // txtIdOrder
            // 
            txtIdOrder.Font = new Font("Times New Roman", 12F);
            txtIdOrder.Location = new Point(153, 12);
            txtIdOrder.Name = "txtIdOrder";
            txtIdOrder.ReadOnly = true;
            txtIdOrder.Size = new Size(184, 30);
            txtIdOrder.TabIndex = 23;
            // 
            // btnExportOrderDetail
            // 
            btnExportOrderDetail.BackColor = Color.AliceBlue;
            btnExportOrderDetail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnExportOrderDetail.ForeColor = Color.MidnightBlue;
            btnExportOrderDetail.Location = new Point(153, 120);
            btnExportOrderDetail.Name = "btnExportOrderDetail";
            btnExportOrderDetail.Size = new Size(120, 49);
            btnExportOrderDetail.TabIndex = 40;
            btnExportOrderDetail.Text = "Xuất file";
            btnExportOrderDetail.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 25;
            label1.Text = "Mã hóa đơn: ";
            // 
            // btnResetOrderDetail
            // 
            btnResetOrderDetail.BackColor = Color.AliceBlue;
            btnResetOrderDetail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnResetOrderDetail.ForeColor = Color.MidnightBlue;
            btnResetOrderDetail.Location = new Point(1023, 120);
            btnResetOrderDetail.Name = "btnResetOrderDetail";
            btnResetOrderDetail.Size = new Size(102, 49);
            btnResetOrderDetail.TabIndex = 39;
            btnResetOrderDetail.Text = "Đặt lại ";
            btnResetOrderDetail.UseVisualStyleBackColor = false;
            btnResetOrderDetail.Click += btnResetOrderDetail_Click;
            // 
            // btnDeleteOrderDetail
            // 
            btnDeleteOrderDetail.BackColor = Color.AliceBlue;
            btnDeleteOrderDetail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDeleteOrderDetail.ForeColor = Color.MidnightBlue;
            btnDeleteOrderDetail.Location = new Point(909, 120);
            btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            btnDeleteOrderDetail.Size = new Size(84, 49);
            btnDeleteOrderDetail.TabIndex = 38;
            btnDeleteOrderDetail.Text = "Xóa ";
            btnDeleteOrderDetail.UseVisualStyleBackColor = false;
            btnDeleteOrderDetail.Click += btnDeleteOrderDetail_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(772, 20);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 27;
            label2.Text = "Tháng: ";
            // 
            // btnEditOrderDetail
            // 
            btnEditOrderDetail.BackColor = Color.AliceBlue;
            btnEditOrderDetail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnEditOrderDetail.ForeColor = Color.MidnightBlue;
            btnEditOrderDetail.Location = new Point(796, 120);
            btnEditOrderDetail.Name = "btnEditOrderDetail";
            btnEditOrderDetail.Size = new Size(84, 49);
            btnEditOrderDetail.TabIndex = 37;
            btnEditOrderDetail.Text = "Sửa ";
            btnEditOrderDetail.UseVisualStyleBackColor = false;
            btnEditOrderDetail.Click += btnEditOrderDetail_Click;
            // 
            // dateTimePickerDetailOrder
            // 
            dateTimePickerDetailOrder.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dateTimePickerDetailOrder.Location = new Point(866, 16);
            dateTimePickerDetailOrder.Name = "dateTimePickerDetailOrder";
            dateTimePickerDetailOrder.Size = new Size(270, 27);
            dateTimePickerDetailOrder.TabIndex = 28;
            // 
            // btnPrintOrderDetail
            // 
            btnPrintOrderDetail.BackColor = Color.AliceBlue;
            btnPrintOrderDetail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnPrintOrderDetail.ForeColor = Color.MidnightBlue;
            btnPrintOrderDetail.Location = new Point(26, 120);
            btnPrintOrderDetail.Name = "btnPrintOrderDetail";
            btnPrintOrderDetail.Size = new Size(96, 49);
            btnPrintOrderDetail.TabIndex = 36;
            btnPrintOrderDetail.Text = "In file";
            btnPrintOrderDetail.UseVisualStyleBackColor = false;
            btnPrintOrderDetail.Click += btnPrintOrderDetail_Click;
            // 
            // btnSaveOrderDetail
            // 
            btnSaveOrderDetail.BackColor = Color.AliceBlue;
            btnSaveOrderDetail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSaveOrderDetail.ForeColor = Color.MidnightBlue;
            btnSaveOrderDetail.Location = new Point(682, 120);
            btnSaveOrderDetail.Name = "btnSaveOrderDetail";
            btnSaveOrderDetail.Size = new Size(84, 49);
            btnSaveOrderDetail.TabIndex = 35;
            btnSaveOrderDetail.Text = "Lưu ";
            btnSaveOrderDetail.UseVisualStyleBackColor = false;
            btnSaveOrderDetail.Click += btnSaveOrderDetail_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(19, 69);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 30;
            label4.Text = "Hợp đồng: ";
            // 
            // btnAddOrderDetail
            // 
            btnAddOrderDetail.BackColor = Color.AliceBlue;
            btnAddOrderDetail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnAddOrderDetail.ForeColor = Color.MidnightBlue;
            btnAddOrderDetail.Location = new Point(565, 120);
            btnAddOrderDetail.Name = "btnAddOrderDetail";
            btnAddOrderDetail.Size = new Size(84, 49);
            btnAddOrderDetail.TabIndex = 34;
            btnAddOrderDetail.Text = "Thêm";
            btnAddOrderDetail.UseVisualStyleBackColor = false;
            btnAddOrderDetail.Click += btnAddOrderDetail_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(380, 12);
            label5.Name = "label5";
            label5.Size = new Size(121, 23);
            label5.TabIndex = 31;
            label5.Text = "Chỉ số nước: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(380, 71);
            label6.Name = "label6";
            label6.Size = new Size(114, 23);
            label6.TabIndex = 32;
            label6.Text = "Chỉ số điện: ";
            // 
            // txtSearchContract
            // 
            txtSearchContract.Font = new Font("Times New Roman", 12F);
            txtSearchContract.Location = new Point(780, 30);
            txtSearchContract.Multiline = true;
            txtSearchContract.Name = "txtSearchContract";
            txtSearchContract.PlaceholderText = "Nhập tìm kiếm ";
            txtSearchContract.Size = new Size(251, 49);
            txtSearchContract.TabIndex = 20;
            // 
            // button8
            // 
            button8.BackColor = Color.AliceBlue;
            button8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button8.ForeColor = Color.MidnightBlue;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(1039, 30);
            button8.Name = "button8";
            button8.Size = new Size(124, 49);
            button8.TabIndex = 21;
            button8.Text = "Tìm kiếm ";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.UseVisualStyleBackColor = false;
            // 
            // fOrderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 783);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fOrderDetail";
            Text = "fOrderDetail";
            Load += fOrderDetail_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadOrderDetail).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewLoadOrderDetail;
        private Panel panel1;
        private TextBox txtSearchContract;
        private Button button8;
        private TextBox txtIdOrder;
        private Button btnExportOrderDetail;
        private Label label1;
        private Button btnResetOrderDetail;
        private Button btnDeleteOrderDetail;
        private Label label2;
        private Button btnEditOrderDetail;
        private DateTimePicker dateTimePickerDetailOrder;
        private Button btnPrintOrderDetail;
        private Button btnSaveOrderDetail;
        private Label label4;
        private Button btnAddOrderDetail;
        private Label label5;
        private Label label6;
        private TextBox txtElectOrderDetail;
        private TextBox txtWaterOrderDetail;
        private ComboBox comboBoxContract;
        private Panel panel2;
        private Button btnDetail;
        private Label label3;
        private Label label7;
    }
}