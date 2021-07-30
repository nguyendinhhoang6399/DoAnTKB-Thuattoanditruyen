using System.Drawing;

namespace Timetable.GUI.Forms
{
    partial class frmKHTTSV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbChonNienKhoa = new System.Windows.Forms.ComboBox();
            this.cbChonHocKi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXemDSNhomHP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbChonBoMon = new System.Windows.Forms.ComboBox();
            this.cboChonKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvKHTT = new System.Windows.Forms.DataGridView();
            this.IdThkhht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTietMoiTuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBuoiMoiTuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdHocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHTT)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.8843F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.1157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1310, 695);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cbChonNienKhoa);
            this.panel1.Controls.Add(this.cbChonHocKi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 90);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(532, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Năm học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(347, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Học kì";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(801, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Liệt kê";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbChonNienKhoa
            // 
            this.cbChonNienKhoa.FormattingEnabled = true;
            this.cbChonNienKhoa.Location = new System.Drawing.Point(617, 44);
            this.cbChonNienKhoa.Name = "cbChonNienKhoa";
            this.cbChonNienKhoa.Size = new System.Drawing.Size(168, 28);
            this.cbChonNienKhoa.TabIndex = 1;
            // 
            // cbChonHocKi
            // 
            this.cbChonHocKi.FormattingEnabled = true;
            this.cbChonHocKi.Location = new System.Drawing.Point(428, 43);
            this.cbChonHocKi.Name = "cbChonHocKi";
            this.cbChonHocKi.Size = new System.Drawing.Size(85, 28);
            this.cbChonHocKi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(450, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dữ liệu đăng kí KHTT theo học phần";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.35737F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.64263F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 99);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1304, 593);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXemDSNhomHP);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbChonBoMon);
            this.panel2.Controls.Add(this.cboChonKhoa);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 587);
            this.panel2.TabIndex = 1;
            // 
            // btnXemDSNhomHP
            // 
            this.btnXemDSNhomHP.Location = new System.Drawing.Point(6, 283);
            this.btnXemDSNhomHP.Name = "btnXemDSNhomHP";
            this.btnXemDSNhomHP.Size = new System.Drawing.Size(231, 29);
            this.btnXemDSNhomHP.TabIndex = 2;
            this.btnXemDSNhomHP.Text = "Xem ds nhóm học phần";
            this.btnXemDSNhomHP.UseVisualStyleBackColor = true;
            this.btnXemDSNhomHP.Click += new System.EventHandler(this.btnXemDSNhomHP_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tự động phân nhóm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chức năng";
            // 
            // cbChonBoMon
            // 
            this.cbChonBoMon.FormattingEnabled = true;
            this.cbChonBoMon.Location = new System.Drawing.Point(6, 94);
            this.cbChonBoMon.Name = "cbChonBoMon";
            this.cbChonBoMon.Size = new System.Drawing.Size(231, 28);
            this.cbChonBoMon.TabIndex = 1;
            // 
            // cboChonKhoa
            // 
            this.cboChonKhoa.FormattingEnabled = true;
            this.cboChonKhoa.Location = new System.Drawing.Point(6, 47);
            this.cboChonKhoa.Name = "cboChonKhoa";
            this.cboChonKhoa.Size = new System.Drawing.Size(231, 28);
            this.cboChonKhoa.TabIndex = 1;
            this.cboChonKhoa.SelectedIndexChanged += new System.EventHandler(this.cboChonKhoa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm kiếm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvKHTT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(255, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1046, 587);
            this.panel3.TabIndex = 2;
            // 
            // dgvKHTT
            // 
            this.dgvKHTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdThkhht,
            this.MaHocPhan,
            this.TenHocPhan,
            this.SoTinChi,
            this.SoTietMoiTuan,
            this.SoBuoiMoiTuan,
            this.SiSo,
            this.IdHocKi,
            this.SoLuongDk});
            this.dgvKHTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKHTT.Location = new System.Drawing.Point(0, 0);
            this.dgvKHTT.Name = "dgvKHTT";
            this.dgvKHTT.RowHeadersWidth = 51;
            this.dgvKHTT.Size = new System.Drawing.Size(1046, 587);
            this.dgvKHTT.TabIndex = 0;
            this.dgvKHTT.Text = "dataGridView1";
            // 
            // IdThkhht
            // 
            this.IdThkhht.DataPropertyName = "IdThkhht";
            this.IdThkhht.HeaderText = "ID";
            this.IdThkhht.MinimumWidth = 6;
            this.IdThkhht.Name = "IdThkhht";
            this.IdThkhht.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdThkhht.Visible = false;
            this.IdThkhht.Width = 125;
            // 
            // MaHocPhan
            // 
            this.MaHocPhan.DataPropertyName = "MaHocPhan";
            this.MaHocPhan.HeaderText = "Mã học phần";
            this.MaHocPhan.MinimumWidth = 6;
            this.MaHocPhan.Name = "MaHocPhan";
            this.MaHocPhan.ReadOnly = true;
            this.MaHocPhan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaHocPhan.Width = 125;
            // 
            // TenHocPhan
            // 
            this.TenHocPhan.DataPropertyName = "TenHocPhan";
            this.TenHocPhan.HeaderText = "Tên học phần";
            this.TenHocPhan.MinimumWidth = 6;
            this.TenHocPhan.Name = "TenHocPhan";
            this.TenHocPhan.ReadOnly = true;
            this.TenHocPhan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenHocPhan.Width = 250;
            // 
            // SoTinChi
            // 
            this.SoTinChi.DataPropertyName = "SoTinChi";
            this.SoTinChi.HeaderText = "Số tín chỉ";
            this.SoTinChi.MinimumWidth = 6;
            this.SoTinChi.Name = "SoTinChi";
            this.SoTinChi.ReadOnly = true;
            this.SoTinChi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoTinChi.Width = 125;
            // 
            // SoTietMoiTuan
            // 
            this.SoTietMoiTuan.DataPropertyName = "SoTietMoiTuan";
            this.SoTietMoiTuan.HeaderText = "Số tiết/tuần";
            this.SoTietMoiTuan.MinimumWidth = 6;
            this.SoTietMoiTuan.Name = "SoTietMoiTuan";
            this.SoTietMoiTuan.ReadOnly = true;
            this.SoTietMoiTuan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoTietMoiTuan.Width = 125;
            // 
            // SoBuoiMoiTuan
            // 
            this.SoBuoiMoiTuan.DataPropertyName = "SoBuoiMoiTuan";
            this.SoBuoiMoiTuan.HeaderText = "Số buổi/tuần";
            this.SoBuoiMoiTuan.MinimumWidth = 6;
            this.SoBuoiMoiTuan.Name = "SoBuoiMoiTuan";
            this.SoBuoiMoiTuan.ReadOnly = true;
            this.SoBuoiMoiTuan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoBuoiMoiTuan.Width = 125;
            // 
            // SiSo
            // 
            this.SiSo.DataPropertyName = "SiSo";
            this.SiSo.HeaderText = "Sĩ số ";
            this.SiSo.MinimumWidth = 6;
            this.SiSo.Name = "SiSo";
            this.SiSo.ReadOnly = true;
            this.SiSo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SiSo.Width = 125;
            // 
            // IdHocKi
            // 
            this.IdHocKi.DataPropertyName = "IdHocKi";
            this.IdHocKi.HeaderText = "HocKi";
            this.IdHocKi.MinimumWidth = 6;
            this.IdHocKi.Name = "IdHocKi";
            this.IdHocKi.ReadOnly = true;
            this.IdHocKi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdHocKi.Visible = false;
            this.IdHocKi.Width = 125;
            // 
            // SoLuongDk
            // 
            this.SoLuongDk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongDk.DataPropertyName = "SoLuongDk";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.SoLuongDk.DefaultCellStyle = dataGridViewCellStyle1;
            this.SoLuongDk.HeaderText = "Số SV đăng kí";
            this.SoLuongDk.MinimumWidth = 6;
            this.SoLuongDk.Name = "SoLuongDk";
            this.SoLuongDk.ReadOnly = true;
            this.SoLuongDk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmKHTTSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 695);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmKHTTSV";
            this.Text = "frmKHTTSV";
            this.Load += new System.EventHandler(this.frmKHTTSV_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbChonNienKhoa;
        private System.Windows.Forms.ComboBox cbChonHocKi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbChonBoMon;
        private System.Windows.Forms.ComboBox cboChonKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvKHTT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnXemDSNhomHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdThkhht;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTietMoiTuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBuoiMoiTuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDk;
    }
}