namespace Timetable.GUI.Forms
{
    partial class frmAddTKB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTKB));
            this.cboHp = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSiSo = new System.Windows.Forms.Label();
            this.lblBuoi = new System.Windows.Forms.Label();
            this.lblTiet = new System.Windows.Forms.Label();
            this.btnThemNhomHP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLichCB = new System.Windows.Forms.DataGridView();
            this.Tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboCanBo = new System.Windows.Forms.ComboBox();
            this.cboPhongHoc = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTietHoc = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichCB)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTietHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // cboHp
            // 
            this.cboHp.FormattingEnabled = true;
            this.cboHp.Location = new System.Drawing.Point(100, 24);
            this.cboHp.Name = "cboHp";
            this.cboHp.Size = new System.Drawing.Size(267, 28);
            this.cboHp.TabIndex = 0;
            this.cboHp.SelectedIndexChanged += new System.EventHandler(this.cboHp_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSiSo);
            this.groupBox1.Controls.Add(this.lblBuoi);
            this.groupBox1.Controls.Add(this.lblTiet);
            this.groupBox1.Controls.Add(this.btnThemNhomHP);
            this.groupBox1.Controls.Add(this.cboHp);
            this.groupBox1.Location = new System.Drawing.Point(37, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhóm học phần";
            // 
            // lblSiSo
            // 
            this.lblSiSo.AutoSize = true;
            this.lblSiSo.Location = new System.Drawing.Point(265, 67);
            this.lblSiSo.Name = "lblSiSo";
            this.lblSiSo.Size = new System.Drawing.Size(44, 20);
            this.lblSiSo.TabIndex = 2;
            this.lblSiSo.Text = "Sĩ số";
            // 
            // lblBuoi
            // 
            this.lblBuoi.AutoSize = true;
            this.lblBuoi.Location = new System.Drawing.Point(138, 67);
            this.lblBuoi.Name = "lblBuoi";
            this.lblBuoi.Size = new System.Drawing.Size(100, 20);
            this.lblBuoi.TabIndex = 2;
            this.lblBuoi.Text = "Số buổi/tuần";
            // 
            // lblTiet
            // 
            this.lblTiet.AutoSize = true;
            this.lblTiet.Location = new System.Drawing.Point(6, 67);
            this.lblTiet.Name = "lblTiet";
            this.lblTiet.Size = new System.Drawing.Size(91, 20);
            this.lblTiet.TabIndex = 2;
            this.lblTiet.Text = "Số tiết/tuần";
            // 
            // btnThemNhomHP
            // 
            this.btnThemNhomHP.Location = new System.Drawing.Point(373, 24);
            this.btnThemNhomHP.Name = "btnThemNhomHP";
            this.btnThemNhomHP.Size = new System.Drawing.Size(108, 63);
            this.btnThemNhomHP.TabIndex = 1;
            this.btnThemNhomHP.Text = "Nhóm HP mới";
            this.btnThemNhomHP.UseVisualStyleBackColor = true;
            this.btnThemNhomHP.Click += new System.EventHandler(this.btnThemNhomHP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLichCB);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(37, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 367);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cán bộ giảng dạy";
            // 
            // dgvLichCB
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichCB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichCB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tiet,
            this.Thu2,
            this.Thu3,
            this.Thu4,
            this.Thu5,
            this.Thu6,
            this.Thu7});
            this.dgvLichCB.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichCB.Location = new System.Drawing.Point(3, 63);
            this.dgvLichCB.Name = "dgvLichCB";
            this.dgvLichCB.RowHeadersWidth = 51;
            this.dgvLichCB.Size = new System.Drawing.Size(534, 301);
            this.dgvLichCB.TabIndex = 1;
            this.dgvLichCB.Text = "dataGridView1";
            this.dgvLichCB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichCB_CellClick);
            // 
            // Tiet
            // 
            this.Tiet.HeaderText = "";
            this.Tiet.MinimumWidth = 6;
            this.Tiet.Name = "Tiet";
            this.Tiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tiet.Width = 60;
            // 
            // Thu2
            // 
            this.Thu2.HeaderText = "T2";
            this.Thu2.MinimumWidth = 6;
            this.Thu2.Name = "Thu2";
            this.Thu2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thu2.Width = 70;
            // 
            // Thu3
            // 
            this.Thu3.HeaderText = "T3";
            this.Thu3.MinimumWidth = 6;
            this.Thu3.Name = "Thu3";
            this.Thu3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thu3.Width = 70;
            // 
            // Thu4
            // 
            this.Thu4.HeaderText = "T4";
            this.Thu4.MinimumWidth = 6;
            this.Thu4.Name = "Thu4";
            this.Thu4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thu4.Width = 70;
            // 
            // Thu5
            // 
            this.Thu5.HeaderText = "T5";
            this.Thu5.MinimumWidth = 6;
            this.Thu5.Name = "Thu5";
            this.Thu5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thu5.Width = 70;
            // 
            // Thu6
            // 
            this.Thu6.HeaderText = "T6";
            this.Thu6.MinimumWidth = 6;
            this.Thu6.Name = "Thu6";
            this.Thu6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thu6.Width = 70;
            // 
            // Thu7
            // 
            this.Thu7.HeaderText = "T7";
            this.Thu7.MinimumWidth = 6;
            this.Thu7.Name = "Thu7";
            this.Thu7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thu7.Width = 70;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboCanBo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 39);
            this.panel1.TabIndex = 0;
            // 
            // cboCanBo
            // 
            this.cboCanBo.FormattingEnabled = true;
            this.cboCanBo.Location = new System.Drawing.Point(97, 3);
            this.cboCanBo.Name = "cboCanBo";
            this.cboCanBo.Size = new System.Drawing.Size(267, 28);
            this.cboCanBo.TabIndex = 0;
            this.cboCanBo.SelectedIndexChanged += new System.EventHandler(this.cboCanBo_SelectedIndexChanged);
            // 
            // cboPhongHoc
            // 
            this.cboPhongHoc.FormattingEnabled = true;
            this.cboPhongHoc.Location = new System.Drawing.Point(97, 22);
            this.cboPhongHoc.Name = "cboPhongHoc";
            this.cboPhongHoc.Size = new System.Drawing.Size(267, 28);
            this.cboPhongHoc.TabIndex = 0;
            this.cboPhongHoc.SelectedIndexChanged += new System.EventHandler(this.cboPhongHoc_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSucChua);
            this.groupBox3.Controls.Add(this.cboPhongHoc);
            this.groupBox3.Location = new System.Drawing.Point(40, 550);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 60);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn phòng học";
            // 
            // lblSucChua
            // 
            this.lblSucChua.AutoSize = true;
            this.lblSucChua.Location = new System.Drawing.Point(369, 25);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(81, 20);
            this.lblSucChua.TabIndex = 2;
            this.lblSucChua.Text = "Sức chứa:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(201, 633);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 40);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(302, 633);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(81, 40);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // dgvTietHoc
            // 
            this.dgvTietHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTietHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvTietHoc.Location = new System.Drawing.Point(17, 655);
            this.dgvTietHoc.Name = "dgvTietHoc";
            this.dgvTietHoc.RowHeadersWidth = 51;
            this.dgvTietHoc.Size = new System.Drawing.Size(10, 10);
            this.dgvTietHoc.TabIndex = 3;
            this.dgvTietHoc.Visible = false;
            // 
            // frmAddTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 712);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTietHoc);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAddTKB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddTKB";
            this.Load += new System.EventHandler(this.frmAddTKB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichCB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTietHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboHp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSiSo;
        private System.Windows.Forms.Label lblBuoi;
        private System.Windows.Forms.Label lblTiet;
        private System.Windows.Forms.Button btnThemNhomHP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboCanBo;
        private System.Windows.Forms.DataGridView dgvLichCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu7;
        private System.Windows.Forms.ComboBox cboPhongHoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvTietHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}