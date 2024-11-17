namespace PhongTro
{
    partial class fReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReport));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            labelRoomFull = new Label();
            labelRoomEmpty = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            labelOutContract = new Label();
            labeLInContract = new Label();
            label7 = new Label();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1175, 775);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(labelRoomFull);
            tabPage1.Controls.Add(labelRoomEmpty);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1167, 742);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thống kê \"Phòng\" ";
            tabPage1.Click += tabPage1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(212, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(639, 510);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(352, 170);
            label3.Name = "label3";
            label3.Size = new Size(401, 33);
            label3.TabIndex = 4;
            label3.Text = "BIỂU ĐỒ TRẠNG THÁI PHÒNG ";
            // 
            // labelRoomFull
            // 
            labelRoomFull.AutoSize = true;
            labelRoomFull.Font = new Font("Times New Roman", 18F);
            labelRoomFull.ForeColor = Color.Black;
            labelRoomFull.Location = new Point(834, 127);
            labelRoomFull.Name = "labelRoomFull";
            labelRoomFull.Size = new Size(85, 34);
            labelRoomFull.TabIndex = 3;
            labelRoomFull.Text = "label3";
            // 
            // labelRoomEmpty
            // 
            labelRoomEmpty.AutoSize = true;
            labelRoomEmpty.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelRoomEmpty.ForeColor = Color.Black;
            labelRoomEmpty.Location = new Point(161, 127);
            labelRoomEmpty.Name = "labelRoomEmpty";
            labelRoomEmpty.Size = new Size(85, 34);
            labelRoomEmpty.TabIndex = 2;
            labelRoomEmpty.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(686, 54);
            label2.Name = "label2";
            label2.Size = new Size(361, 32);
            label2.TabIndex = 1;
            label2.Text = "Tổng PHÒNG ĐANG THUÊ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(66, 54);
            label1.Name = "label1";
            label1.Size = new Size(302, 32);
            label1.TabIndex = 0;
            label1.Text = "Tổng PHÒNG TRỐNG ";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(labelOutContract);
            tabPage2.Controls.Add(labeLInContract);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1167, 742);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thống kê \"Hợp đồng\" ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(251, 221);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(603, 496);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(346, 185);
            label4.Name = "label4";
            label4.Size = new Size(440, 33);
            label4.TabIndex = 9;
            label4.Text = "BIỂU ĐỒ TRẠNG THÁI HỢP ĐỒNG";
            // 
            // labelOutContract
            // 
            labelOutContract.AutoSize = true;
            labelOutContract.Font = new Font("Times New Roman", 18F);
            labelOutContract.ForeColor = Color.Black;
            labelOutContract.Location = new Point(883, 145);
            labelOutContract.Name = "labelOutContract";
            labelOutContract.Size = new Size(85, 34);
            labelOutContract.TabIndex = 8;
            labelOutContract.Text = "label3";
            // 
            // labeLInContract
            // 
            labeLInContract.AutoSize = true;
            labeLInContract.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labeLInContract.ForeColor = Color.Black;
            labeLInContract.Location = new Point(191, 145);
            labeLInContract.Name = "labeLInContract";
            labeLInContract.Size = new Size(85, 34);
            labeLInContract.TabIndex = 7;
            labeLInContract.Text = "label3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(670, 73);
            label7.Name = "label7";
            label7.Size = new Size(446, 32);
            label7.TabIndex = 6;
            label7.Text = "Tổng HỢP ĐỒNG HẾT THỜI HẠN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(51, 73);
            label8.Name = "label8";
            label8.Size = new Size(450, 32);
            label8.TabIndex = 5;
            label8.Text = "Tổng HỢP ĐỒNG CÒN THỜI HẠN";
            // 
            // fReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1175, 783);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fReport";
            Text = "fReport";
            Load += fReport_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Label label3;
        private Label labelRoomFull;
        private Label labelRoomEmpty;
        private Label label2;
        private Label label4;
        private Label labelOutContract;
        private Label labeLInContract;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}