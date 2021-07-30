namespace Timetable.GUI.Forms
{
    partial class frmTKBGiaoVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblthongbao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblmacb = new System.Windows.Forms.Label();
            this.lblSoTC = new System.Windows.Forms.Label();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.lblTenHP = new System.Windows.Forms.Label();
            this.dgvLichGV = new System.Windows.Forms.DataGridView();
            this.lblkytu = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.cboBoMon = new System.Windows.Forms.ComboBox();
            this.cboGiangVien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSoNhomVP = new System.Windows.Forms.Label();
            this.lblSoNhomHopLe = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichGV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(462, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời khóa biểu cán bộ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(452, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn giảng viên để xem  lịch dạy";
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblthongbao.Location = new System.Drawing.Point(1072, 485);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(0, 16);
            this.lblthongbao.TabIndex = 88;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblChuyenNganh);
            this.groupBox1.Controls.Add(this.lblChucVu);
            this.groupBox1.Controls.Add(this.lblTen);
            this.groupBox1.Controls.Add(this.lblmacb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(1084, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(222, 256);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giảng viên";
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChuyenNganh.Location = new System.Drawing.Point(8, 129);
            this.lblChuyenNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(96, 18);
            this.lblChuyenNganh.TabIndex = 0;
            this.lblChuyenNganh.Text = "Chuyên môn:";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChucVu.Location = new System.Drawing.Point(8, 100);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(62, 18);
            this.lblChucVu.TabIndex = 0;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTen.Location = new System.Drawing.Point(8, 71);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(56, 18);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Họ tên:";
            // 
            // lblmacb
            // 
            this.lblmacb.AutoSize = true;
            this.lblmacb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblmacb.Location = new System.Drawing.Point(8, 42);
            this.lblmacb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmacb.Name = "lblmacb";
            this.lblmacb.Size = new System.Drawing.Size(54, 18);
            this.lblmacb.TabIndex = 0;
            this.lblmacb.Text = "Mã CB";
            // 
            // lblSoTC
            // 
            this.lblSoTC.AutoSize = true;
            this.lblSoTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoTC.Location = new System.Drawing.Point(850, 201);
            this.lblSoTC.Name = "lblSoTC";
            this.lblSoTC.Size = new System.Drawing.Size(92, 25);
            this.lblSoTC.TabIndex = 82;
            this.lblSoTC.Text = "Số tín chỉ";
            // 
            // lblMaHP
            // 
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaHP.Location = new System.Drawing.Point(47, 201);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(126, 25);
            this.lblMaHP.TabIndex = 81;
            this.lblMaHP.Text = "Mã học phần";
            // 
            // lblTenHP
            // 
            this.lblTenHP.AutoSize = true;
            this.lblTenHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenHP.Location = new System.Drawing.Point(363, 201);
            this.lblTenHP.Name = "lblTenHP";
            this.lblTenHP.Size = new System.Drawing.Size(133, 25);
            this.lblTenHP.TabIndex = 80;
            this.lblTenHP.Text = "Tên học phần";
            // 
            // dgvLichGV
            // 
            this.dgvLichGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dgvLichGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichGV.Location = new System.Drawing.Point(47, 229);
            this.dgvLichGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvLichGV.Name = "dgvLichGV";
            this.dgvLichGV.ReadOnly = true;
            this.dgvLichGV.RowHeadersWidth = 51;
            this.dgvLichGV.Size = new System.Drawing.Size(1025, 570);
            this.dgvLichGV.TabIndex = 79;
            this.dgvLichGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichGV_CellClick);
            // 
            // lblkytu
            // 
            this.lblkytu.AutoSize = true;
            this.lblkytu.Location = new System.Drawing.Point(1064, 666);
            this.lblkytu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkytu.Name = "lblkytu";
            this.lblkytu.Size = new System.Drawing.Size(0, 20);
            this.lblkytu.TabIndex = 87;
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(71, 28);
            this.cboKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(227, 28);
            this.cboKhoa.TabIndex = 89;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // cboBoMon
            // 
            this.cboBoMon.FormattingEnabled = true;
            this.cboBoMon.Items.AddRange(new object[] {
            "-------------Chọn Bộ Môn-------------"});
            this.cboBoMon.Location = new System.Drawing.Point(413, 28);
            this.cboBoMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboBoMon.Name = "cboBoMon";
            this.cboBoMon.Size = new System.Drawing.Size(240, 28);
            this.cboBoMon.TabIndex = 90;
            this.cboBoMon.SelectedIndexChanged += new System.EventHandler(this.cboBoMon_SelectedIndexChanged);
            // 
            // cboGiangVien
            // 
            this.cboGiangVien.FormattingEnabled = true;
            this.cboGiangVien.Items.AddRange(new object[] {
            "-------------Chọn Giảng Viên-------------"});
            this.cboGiangVien.Location = new System.Drawing.Point(761, 28);
            this.cboGiangVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboGiangVien.Name = "cboGiangVien";
            this.cboGiangVien.Size = new System.Drawing.Size(240, 28);
            this.cboGiangVien.TabIndex = 91;
            this.cboGiangVien.SelectedIndexChanged += new System.EventHandler(this.cboGiangVien_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(328, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 92;
            this.label3.Text = "Bộ môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 93;
            this.label4.Text = "Khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(659, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 94;
            this.label5.Text = "Giảng viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cboGiangVien);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cboKhoa);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cboBoMon);
            this.groupBox3.Location = new System.Drawing.Point(47, 115);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1030, 82);
            this.groupBox3.TabIndex = 95;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn giảng viên để xem  lịch dạy";
            // 
            // lblSoNhomVP
            // 
            this.lblSoNhomVP.AutoSize = true;
            this.lblSoNhomVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoNhomVP.Location = new System.Drawing.Point(8, 78);
            this.lblSoNhomVP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoNhomVP.Name = "lblSoNhomVP";
            this.lblSoNhomVP.Size = new System.Drawing.Size(65, 18);
            this.lblSoNhomVP.TabIndex = 0;
            this.lblSoNhomVP.Text = "Vi phạm:";
            // 
            // lblSoNhomHopLe
            // 
            this.lblSoNhomHopLe.AutoSize = true;
            this.lblSoNhomHopLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoNhomHopLe.Location = new System.Drawing.Point(8, 40);
            this.lblSoNhomHopLe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoNhomHopLe.Name = "lblSoNhomHopLe";
            this.lblSoNhomHopLe.Size = new System.Drawing.Size(55, 18);
            this.lblSoNhomHopLe.TabIndex = 0;
            this.lblSoNhomHopLe.Text = "Hợp lệ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSoNhomHopLe);
            this.groupBox2.Controls.Add(this.lblSoNhomVP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(1087, 381);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(219, 112);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giảng dạy";
            // 
            // frmTKBGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 838);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblthongbao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSoTC);
            this.Controls.Add(this.lblMaHP);
            this.Controls.Add(this.lblTenHP);
            this.Controls.Add(this.dgvLichGV);
            this.Controls.Add(this.lblkytu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTKBGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Thời khóa biểu cán bộ";
            this.Load += new System.EventHandler(this.frmTKBGiaoVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichGV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblthongbao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblmacb;
        private System.Windows.Forms.Label lblSoTC;
        private System.Windows.Forms.Label lblMaHP;
        private System.Windows.Forms.Label lblTenHP;
        private System.Windows.Forms.Label lblkytu;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.ComboBox cboBoMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSoNhomVP;
        private System.Windows.Forms.Label lblSoNhomHopLe;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvLichGV;
        public System.Windows.Forms.ComboBox cboGiangVien;
    }
}