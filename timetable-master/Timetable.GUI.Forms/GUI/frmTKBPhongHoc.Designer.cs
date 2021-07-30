namespace Timetable.GUI.Forms
{
    partial class frmTKBPhongHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTongHopLe = new System.Windows.Forms.Label();
            this.cboPhongHoc = new System.Windows.Forms.ComboBox();
            this.lblSapLich = new System.Windows.Forms.Label();
            this.lblVipham = new System.Windows.Forms.Label();
            this.lblkytu = new System.Windows.Forms.Label();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gboxThongtin = new System.Windows.Forms.GroupBox();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.txtSoBuoi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBoMon = new System.Windows.Forms.TextBox();
            this.txtCanbo = new System.Windows.Forms.TextBox();
            this.txtNhomHp = new System.Windows.Forms.TextBox();
            this.txtHocPhan = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTKBPhongHoc = new System.Windows.Forms.DataGridView();
            this.gboxThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKBPhongHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTongHopLe
            // 
            this.lblTongHopLe.AutoSize = true;
            this.lblTongHopLe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTongHopLe.Location = new System.Drawing.Point(515, 110);
            this.lblTongHopLe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongHopLe.Name = "lblTongHopLe";
            this.lblTongHopLe.Size = new System.Drawing.Size(74, 23);
            this.lblTongHopLe.TabIndex = 62;
            this.lblTongHopLe.Text = "Hợp lệ:";
            // 
            // cboPhongHoc
            // 
            this.cboPhongHoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPhongHoc.FormattingEnabled = true;
            this.cboPhongHoc.Location = new System.Drawing.Point(67, 107);
            this.cboPhongHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPhongHoc.Name = "cboPhongHoc";
            this.cboPhongHoc.Size = new System.Drawing.Size(211, 26);
            this.cboPhongHoc.TabIndex = 51;
            this.cboPhongHoc.SelectedIndexChanged += new System.EventHandler(this.cboPhongHoc_SelectedIndexChanged);
            // 
            // lblSapLich
            // 
            this.lblSapLich.AutoSize = true;
            this.lblSapLich.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSapLich.Location = new System.Drawing.Point(300, 110);
            this.lblSapLich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSapLich.Name = "lblSapLich";
            this.lblSapLich.Size = new System.Drawing.Size(113, 23);
            this.lblSapLich.TabIndex = 74;
            this.lblSapLich.Text = "Đã sắp lịch:";
            // 
            // lblVipham
            // 
            this.lblVipham.AutoSize = true;
            this.lblVipham.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVipham.ForeColor = System.Drawing.Color.Red;
            this.lblVipham.Location = new System.Drawing.Point(725, 111);
            this.lblVipham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVipham.Name = "lblVipham";
            this.lblVipham.Size = new System.Drawing.Size(87, 23);
            this.lblVipham.TabIndex = 75;
            this.lblVipham.Text = "Vi phạm:";
            // 
            // lblkytu
            // 
            this.lblkytu.AutoSize = true;
            this.lblkytu.Location = new System.Drawing.Point(1112, 730);
            this.lblkytu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkytu.Name = "lblkytu";
            this.lblkytu.Size = new System.Drawing.Size(0, 20);
            this.lblkytu.TabIndex = 70;
            // 
            // lblSucChua
            // 
            this.lblSucChua.AutoSize = true;
            this.lblSucChua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSucChua.Location = new System.Drawing.Point(903, 111);
            this.lblSucChua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(102, 23);
            this.lblSucChua.TabIndex = 76;
            this.lblSucChua.Text = "Sức chứa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(505, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(307, 33);
            this.label11.TabIndex = 77;
            this.label11.Text = "Thời khóa biểu phòng học";
            // 
            // gboxThongtin
            // 
            this.gboxThongtin.Controls.Add(this.txtSiSo);
            this.gboxThongtin.Controls.Add(this.txtSoBuoi);
            this.gboxThongtin.Controls.Add(this.txtEmail);
            this.gboxThongtin.Controls.Add(this.txtBoMon);
            this.gboxThongtin.Controls.Add(this.txtCanbo);
            this.gboxThongtin.Controls.Add(this.txtNhomHp);
            this.gboxThongtin.Controls.Add(this.txtHocPhan);
            this.gboxThongtin.Controls.Add(this.lblEmail);
            this.gboxThongtin.Controls.Add(this.label6);
            this.gboxThongtin.Controls.Add(this.label5);
            this.gboxThongtin.Controls.Add(this.label3);
            this.gboxThongtin.Controls.Add(this.label4);
            this.gboxThongtin.Controls.Add(this.label2);
            this.gboxThongtin.Controls.Add(this.label1);
            this.gboxThongtin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gboxThongtin.Location = new System.Drawing.Point(67, 581);
            this.gboxThongtin.Name = "gboxThongtin";
            this.gboxThongtin.Size = new System.Drawing.Size(1033, 148);
            this.gboxThongtin.TabIndex = 78;
            this.gboxThongtin.TabStop = false;
            this.gboxThongtin.Text = "Thông tin lớp học phần";
            // 
            // txtSiSo
            // 
            this.txtSiSo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSiSo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSiSo.Location = new System.Drawing.Point(383, 111);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.ReadOnly = true;
            this.txtSiSo.Size = new System.Drawing.Size(133, 24);
            this.txtSiSo.TabIndex = 1;
            // 
            // txtSoBuoi
            // 
            this.txtSoBuoi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSoBuoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoBuoi.Location = new System.Drawing.Point(195, 111);
            this.txtSoBuoi.Name = "txtSoBuoi";
            this.txtSoBuoi.ReadOnly = true;
            this.txtSoBuoi.Size = new System.Drawing.Size(115, 24);
            this.txtSoBuoi.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(681, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(321, 24);
            this.txtEmail.TabIndex = 1;
            // 
            // txtBoMon
            // 
            this.txtBoMon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBoMon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoMon.Location = new System.Drawing.Point(681, 73);
            this.txtBoMon.Name = "txtBoMon";
            this.txtBoMon.ReadOnly = true;
            this.txtBoMon.Size = new System.Drawing.Size(321, 24);
            this.txtBoMon.TabIndex = 1;
            // 
            // txtCanbo
            // 
            this.txtCanbo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCanbo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCanbo.Location = new System.Drawing.Point(681, 36);
            this.txtCanbo.Name = "txtCanbo";
            this.txtCanbo.ReadOnly = true;
            this.txtCanbo.Size = new System.Drawing.Size(321, 24);
            this.txtCanbo.TabIndex = 1;
            // 
            // txtNhomHp
            // 
            this.txtNhomHp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNhomHp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNhomHp.Location = new System.Drawing.Point(195, 73);
            this.txtNhomHp.Name = "txtNhomHp";
            this.txtNhomHp.ReadOnly = true;
            this.txtNhomHp.Size = new System.Drawing.Size(321, 24);
            this.txtNhomHp.TabIndex = 1;
            // 
            // txtHocPhan
            // 
            this.txtHocPhan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtHocPhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHocPhan.Location = new System.Drawing.Point(195, 36);
            this.txtHocPhan.Name = "txtHocPhan";
            this.txtHocPhan.ReadOnly = true;
            this.txtHocPhan.Size = new System.Drawing.Size(321, 24);
            this.txtHocPhan.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(621, 114);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 25);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bộ môn ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cán bộ giảng dạy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sĩ số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số buổi học/tuần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhóm học phần";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học phần";
            // 
            // Tiet
            // 
            this.Tiet.DataPropertyName = "Tiet";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tiet.DefaultCellStyle = dataGridViewCellStyle1;
            this.Tiet.HeaderText = "";
            this.Tiet.MinimumWidth = 6;
            this.Tiet.Name = "Tiet";
            this.Tiet.ReadOnly = true;
            this.Tiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tiet.Width = 90;
            // 
            // Thu2
            // 
            this.Thu2.DataPropertyName = "Thu2";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Thu2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Thu2.HeaderText = "Thứ 2";
            this.Thu2.MinimumWidth = 6;
            this.Thu2.Name = "Thu2";
            this.Thu2.ReadOnly = true;
            this.Thu2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thu2.Width = 150;
            // 
            // Thu3
            // 
            this.Thu3.DataPropertyName = "Thu3";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Thu3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Thu3.HeaderText = "Thứ 3";
            this.Thu3.MinimumWidth = 6;
            this.Thu3.Name = "Thu3";
            this.Thu3.ReadOnly = true;
            this.Thu3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thu3.Width = 150;
            // 
            // Thu4
            // 
            this.Thu4.DataPropertyName = "Thu4";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Thu4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Thu4.HeaderText = "Thứ 4";
            this.Thu4.MinimumWidth = 6;
            this.Thu4.Name = "Thu4";
            this.Thu4.ReadOnly = true;
            this.Thu4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thu4.Width = 150;
            // 
            // Thu5
            // 
            this.Thu5.DataPropertyName = "Thu5";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Thu5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Thu5.HeaderText = "Thứ 5";
            this.Thu5.MinimumWidth = 6;
            this.Thu5.Name = "Thu5";
            this.Thu5.ReadOnly = true;
            this.Thu5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thu5.Width = 150;
            // 
            // Thu6
            // 
            this.Thu6.DataPropertyName = "Thu6";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Thu6.DefaultCellStyle = dataGridViewCellStyle6;
            this.Thu6.HeaderText = "Thứ 6";
            this.Thu6.MinimumWidth = 6;
            this.Thu6.Name = "Thu6";
            this.Thu6.ReadOnly = true;
            this.Thu6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thu6.Width = 150;
            // 
            // Thu7
            // 
            this.Thu7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thu7.DataPropertyName = "Thu7";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Thu7.DefaultCellStyle = dataGridViewCellStyle7;
            this.Thu7.HeaderText = "Thứ 7";
            this.Thu7.MinimumWidth = 6;
            this.Thu7.Name = "Thu7";
            this.Thu7.ReadOnly = true;
            this.Thu7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvTKBPhongHoc
            // 
            this.dgvTKBPhongHoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dgvTKBPhongHoc.ColumnHeadersHeight = 29;
            this.dgvTKBPhongHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTKBPhongHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tiet,
            this.Thu2,
            this.Thu3,
            this.Thu4,
            this.Thu5,
            this.Thu6,
            this.Thu7});
            this.dgvTKBPhongHoc.Location = new System.Drawing.Point(67, 158);
            this.dgvTKBPhongHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTKBPhongHoc.Name = "dgvTKBPhongHoc";
            this.dgvTKBPhongHoc.ReadOnly = true;
            this.dgvTKBPhongHoc.RowHeadersWidth = 51;
            this.dgvTKBPhongHoc.Size = new System.Drawing.Size(1036, 395);
            this.dgvTKBPhongHoc.TabIndex = 63;
            this.dgvTKBPhongHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTKBPhongHoc_CellClick);
            this.dgvTKBPhongHoc.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTKBPhongHoc_CellFormatting);
            this.dgvTKBPhongHoc.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvTKBPhongHoc_CellPainting);
            // 
            // frmTKBPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 753);
            this.Controls.Add(this.gboxThongtin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSucChua);
            this.Controls.Add(this.lblVipham);
            this.Controls.Add(this.lblSapLich);
            this.Controls.Add(this.lblkytu);
            this.Controls.Add(this.dgvTKBPhongHoc);
            this.Controls.Add(this.lblTongHopLe);
            this.Controls.Add(this.cboPhongHoc);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTKBPhongHoc";
            this.Text = "Thời khóa biểu phòng học";
            this.Load += new System.EventHandler(this.frmTKBPhongHoc_Load);
            this.gboxThongtin.ResumeLayout(false);
            this.gboxThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKBPhongHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTongHopLe;
        private System.Windows.Forms.Label lblSapLich;
        private System.Windows.Forms.Label lblVipham;
        private System.Windows.Forms.Label lblkytu;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.DataGridView dgvTKBPhongHoc;
        public System.Windows.Forms.ComboBox cboPhongHoc;
        private System.Windows.Forms.GroupBox gboxThongtin;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.TextBox txtSoBuoi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBoMon;
        private System.Windows.Forms.TextBox txtCanbo;
        private System.Windows.Forms.TextBox txtNhomHp;
        private System.Windows.Forms.TextBox txtHocPhan;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu7;
    }
}