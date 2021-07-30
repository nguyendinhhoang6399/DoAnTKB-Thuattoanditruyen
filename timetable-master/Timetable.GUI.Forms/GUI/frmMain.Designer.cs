namespace Timetable.GUI.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.btnNhomHP = new System.Windows.Forms.Button();
            this.btnDonViData = new System.Windows.Forms.Button();
            this.btnTimeslotData = new System.Windows.Forms.Button();
            this.btnHocPhanData = new System.Windows.Forms.Button();
            this.btnPhongHocData = new System.Windows.Forms.Button();
            this.btnCanBoData = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnSapXepTKB = new System.Windows.Forms.Button();
            this.btnKHHTData = new System.Windows.Forms.Button();
            this.btnTKB = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGiangDay = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 568F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 568F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 568F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 568F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.btnNhomHP);
            this.panel1.Controls.Add(this.btnDonViData);
            this.panel1.Controls.Add(this.btnTimeslotData);
            this.panel1.Controls.Add(this.btnHocPhanData);
            this.panel1.Controls.Add(this.btnPhongHocData);
            this.panel1.Controls.Add(this.btnCanBoData);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 494);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblData.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblData.ForeColor = System.Drawing.SystemColors.Control;
            this.lblData.Location = new System.Drawing.Point(169, 57);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(146, 23);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Khởi tạo dữ liệu";
            // 
            // btnNhomHP
            // 
            this.btnNhomHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNhomHP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhomHP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNhomHP.Image = ((System.Drawing.Image)(resources.GetObject("btnNhomHP.Image")));
            this.btnNhomHP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNhomHP.Location = new System.Drawing.Point(249, 368);
            this.btnNhomHP.Name = "btnNhomHP";
            this.btnNhomHP.Size = new System.Drawing.Size(197, 93);
            this.btnNhomHP.TabIndex = 0;
            this.btnNhomHP.Text = "Nhóm học phần";
            this.btnNhomHP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhomHP.UseVisualStyleBackColor = false;
            this.btnNhomHP.Click += new System.EventHandler(this.btnNhomHP_Click);
            // 
            // btnDonViData
            // 
            this.btnDonViData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDonViData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonViData.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDonViData.Image = ((System.Drawing.Image)(resources.GetObject("btnDonViData.Image")));
            this.btnDonViData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDonViData.Location = new System.Drawing.Point(46, 110);
            this.btnDonViData.Name = "btnDonViData";
            this.btnDonViData.Size = new System.Drawing.Size(197, 93);
            this.btnDonViData.TabIndex = 0;
            this.btnDonViData.Text = "Dữ liệu đơn vị";
            this.btnDonViData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDonViData.UseVisualStyleBackColor = false;
            this.btnDonViData.Click += new System.EventHandler(this.btnDonViData_Click);
            // 
            // btnTimeslotData
            // 
            this.btnTimeslotData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimeslotData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeslotData.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimeslotData.Image = ((System.Drawing.Image)(resources.GetObject("btnTimeslotData.Image")));
            this.btnTimeslotData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimeslotData.Location = new System.Drawing.Point(46, 368);
            this.btnTimeslotData.Name = "btnTimeslotData";
            this.btnTimeslotData.Size = new System.Drawing.Size(197, 93);
            this.btnTimeslotData.TabIndex = 0;
            this.btnTimeslotData.Text = "Thời gian học";
            this.btnTimeslotData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimeslotData.UseVisualStyleBackColor = false;
            this.btnTimeslotData.Click += new System.EventHandler(this.btnTimeslotData_Click);
            // 
            // btnHocPhanData
            // 
            this.btnHocPhanData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHocPhanData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHocPhanData.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHocPhanData.Image = ((System.Drawing.Image)(resources.GetObject("btnHocPhanData.Image")));
            this.btnHocPhanData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHocPhanData.Location = new System.Drawing.Point(46, 239);
            this.btnHocPhanData.Name = "btnHocPhanData";
            this.btnHocPhanData.Size = new System.Drawing.Size(197, 93);
            this.btnHocPhanData.TabIndex = 0;
            this.btnHocPhanData.Text = "Dữ liệu học phần";
            this.btnHocPhanData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHocPhanData.UseVisualStyleBackColor = false;
            this.btnHocPhanData.Click += new System.EventHandler(this.btnHocPhanData_Click);
            // 
            // btnPhongHocData
            // 
            this.btnPhongHocData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPhongHocData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhongHocData.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPhongHocData.Image = ((System.Drawing.Image)(resources.GetObject("btnPhongHocData.Image")));
            this.btnPhongHocData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPhongHocData.Location = new System.Drawing.Point(249, 239);
            this.btnPhongHocData.Name = "btnPhongHocData";
            this.btnPhongHocData.Size = new System.Drawing.Size(197, 93);
            this.btnPhongHocData.TabIndex = 0;
            this.btnPhongHocData.Text = "Dữ liệu phòng học";
            this.btnPhongHocData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhongHocData.UseVisualStyleBackColor = false;
            this.btnPhongHocData.Click += new System.EventHandler(this.btnPhongHocData_Click);
            // 
            // btnCanBoData
            // 
            this.btnCanBoData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCanBoData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanBoData.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCanBoData.Image = ((System.Drawing.Image)(resources.GetObject("btnCanBoData.Image")));
            this.btnCanBoData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCanBoData.Location = new System.Drawing.Point(249, 110);
            this.btnCanBoData.Name = "btnCanBoData";
            this.btnCanBoData.Size = new System.Drawing.Size(197, 93);
            this.btnCanBoData.TabIndex = 0;
            this.btnCanBoData.Text = "Dữ liệu cán bộ";
            this.btnCanBoData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCanBoData.UseVisualStyleBackColor = false;
            this.btnCanBoData.Click += new System.EventHandler(this.btnCanBoData_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnSapXepTKB);
            this.panel2.Controls.Add(this.btnKHHTData);
            this.panel2.Controls.Add(this.btnTKB);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnGiangDay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(496, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 494);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(439, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(344, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Đăng xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(182, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chức năng";
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetting.Location = new System.Drawing.Point(37, 368);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(197, 93);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnSapXepTKB
            // 
            this.btnSapXepTKB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSapXepTKB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSapXepTKB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSapXepTKB.Image = ((System.Drawing.Image)(resources.GetObject("btnSapXepTKB.Image")));
            this.btnSapXepTKB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSapXepTKB.Location = new System.Drawing.Point(240, 110);
            this.btnSapXepTKB.Name = "btnSapXepTKB";
            this.btnSapXepTKB.Size = new System.Drawing.Size(197, 93);
            this.btnSapXepTKB.TabIndex = 0;
            this.btnSapXepTKB.Text = "Sắp thời khóa biểu";
            this.btnSapXepTKB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSapXepTKB.UseVisualStyleBackColor = false;
            this.btnSapXepTKB.Click += new System.EventHandler(this.btnSapXepTKB_Click);
            // 
            // btnKHHTData
            // 
            this.btnKHHTData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKHHTData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKHHTData.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKHHTData.Image = ((System.Drawing.Image)(resources.GetObject("btnKHHTData.Image")));
            this.btnKHHTData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKHHTData.Location = new System.Drawing.Point(37, 239);
            this.btnKHHTData.Name = "btnKHHTData";
            this.btnKHHTData.Size = new System.Drawing.Size(197, 93);
            this.btnKHHTData.TabIndex = 0;
            this.btnKHHTData.Text = "Phân nhóm học phần";
            this.btnKHHTData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKHHTData.UseVisualStyleBackColor = false;
            this.btnKHHTData.Click += new System.EventHandler(this.btnKHHTData_Click);
            // 
            // btnTKB
            // 
            this.btnTKB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTKB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTKB.Image = ((System.Drawing.Image)(resources.GetObject("btnTKB.Image")));
            this.btnTKB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTKB.Location = new System.Drawing.Point(37, 110);
            this.btnTKB.Name = "btnTKB";
            this.btnTKB.Size = new System.Drawing.Size(197, 93);
            this.btnTKB.TabIndex = 0;
            this.btnTKB.Text = "Thời khóa biểu";
            this.btnTKB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTKB.UseVisualStyleBackColor = false;
            this.btnTKB.Click += new System.EventHandler(this.btnTKB_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(240, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(197, 93);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGiangDay
            // 
            this.btnGiangDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGiangDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiangDay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGiangDay.Image = ((System.Drawing.Image)(resources.GetObject("btnGiangDay.Image")));
            this.btnGiangDay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGiangDay.Location = new System.Drawing.Point(240, 239);
            this.btnGiangDay.Name = "btnGiangDay";
            this.btnGiangDay.Size = new System.Drawing.Size(197, 93);
            this.btnGiangDay.TabIndex = 0;
            this.btnGiangDay.Text = "Phân công giảng dạy";
            this.btnGiangDay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGiangDay.UseVisualStyleBackColor = false;
            this.btnGiangDay.Click += new System.EventHandler(this.btnGiangDay_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(986, 500);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phần mềm lập lịch thời khóa biểu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnNhomHP;
        private System.Windows.Forms.Button btnDonViData;
        private System.Windows.Forms.Button btnGiangDay;
        private System.Windows.Forms.Button btnTimeslotData;
        private System.Windows.Forms.Button btnKHHTData;
        private System.Windows.Forms.Button btnHocPhanData;
        private System.Windows.Forms.Button btnPhongHocData;
        private System.Windows.Forms.Button btnCanBoData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTKB;
        private System.Windows.Forms.Button btnSapXepTKB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
    }
}