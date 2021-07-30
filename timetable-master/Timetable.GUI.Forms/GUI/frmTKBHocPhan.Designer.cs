using System.Drawing;

namespace Timetable.GUI.Forms
{
    partial class frmTKBHocPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTKBHocPhan));
            this.label1 = new System.Windows.Forms.Label();
            this.cboChonHP = new System.Windows.Forms.ComboBox();
            this.lblTenHP = new System.Windows.Forms.Label();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.lblSoTC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblViPham = new System.Windows.Forms.Label();
            this.lblkytu = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSoNhomHopLe = new System.Windows.Forms.Label();
            this.lblSoNhomVP = new System.Windows.Forms.Label();
            this.lblthongbao = new System.Windows.Forms.Label();
            this.chkChoose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KyHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhomHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TietBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkChooseAll = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTKB = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(467, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời khóa biểu học phần";
            // 
            // cboChonHP
            // 
            this.cboChonHP.FormattingEnabled = true;
            this.cboChonHP.Location = new System.Drawing.Point(427, 83);
            this.cboChonHP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboChonHP.Name = "cboChonHP";
            this.cboChonHP.Size = new System.Drawing.Size(365, 28);
            this.cboChonHP.TabIndex = 2;
            this.cboChonHP.SelectedIndexChanged += new System.EventHandler(this.cboChonHP_SelectedIndexChanged);
            // 
            // lblTenHP
            // 
            this.lblTenHP.AutoSize = true;
            this.lblTenHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenHP.Location = new System.Drawing.Point(382, 128);
            this.lblTenHP.Name = "lblTenHP";
            this.lblTenHP.Size = new System.Drawing.Size(133, 25);
            this.lblTenHP.TabIndex = 3;
            this.lblTenHP.Text = "Tên học phần";
            // 
            // lblMaHP
            // 
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaHP.Location = new System.Drawing.Point(54, 128);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(126, 25);
            this.lblMaHP.TabIndex = 4;
            this.lblMaHP.Text = "Mã học phần";
            // 
            // lblSoTC
            // 
            this.lblSoTC.AutoSize = true;
            this.lblSoTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoTC.Location = new System.Drawing.Point(875, 128);
            this.lblSoTC.Name = "lblSoTC";
            this.lblSoTC.Size = new System.Drawing.Size(92, 25);
            this.lblSoTC.TabIndex = 5;
            this.lblSoTC.Text = "Số tín chỉ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblViPham);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(1045, 175);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(258, 359);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chú thích";
            // 
            // lblViPham
            // 
            this.lblViPham.AutoSize = true;
            this.lblViPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblViPham.Location = new System.Drawing.Point(8, 45);
            this.lblViPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViPham.Name = "lblViPham";
            this.lblViPham.Size = new System.Drawing.Size(138, 20);
            this.lblViPham.TabIndex = 0;
            this.lblViPham.Text = "0: Không vi phạm";
            // 
            // lblkytu
            // 
            this.lblkytu.AutoSize = true;
            this.lblkytu.Location = new System.Drawing.Point(1045, 684);
            this.lblkytu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkytu.Name = "lblkytu";
            this.lblkytu.Size = new System.Drawing.Size(0, 20);
            this.lblkytu.TabIndex = 77;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSoNhomHopLe);
            this.groupBox2.Controls.Add(this.lblSoNhomVP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(1045, 544);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(239, 112);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng lớp HP: ";
            // 
            // lblSoNhomHopLe
            // 
            this.lblSoNhomHopLe.AutoSize = true;
            this.lblSoNhomHopLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoNhomHopLe.Location = new System.Drawing.Point(8, 40);
            this.lblSoNhomHopLe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoNhomHopLe.Name = "lblSoNhomHopLe";
            this.lblSoNhomHopLe.Size = new System.Drawing.Size(63, 20);
            this.lblSoNhomHopLe.TabIndex = 0;
            this.lblSoNhomHopLe.Text = "Hợp lệ:";
            // 
            // lblSoNhomVP
            // 
            this.lblSoNhomVP.AutoSize = true;
            this.lblSoNhomVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoNhomVP.Location = new System.Drawing.Point(8, 78);
            this.lblSoNhomVP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoNhomVP.Name = "lblSoNhomVP";
            this.lblSoNhomVP.Size = new System.Drawing.Size(75, 20);
            this.lblSoNhomVP.TabIndex = 0;
            this.lblSoNhomVP.Text = "Vi phạm:";
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblthongbao.Location = new System.Drawing.Point(1064, 661);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(239, 18);
            this.lblthongbao.TabIndex = 78;
            this.lblthongbao.Text = "Hết vi phạm có thể xuất dữ liệu";
            // 
            // chkChoose
            // 
            this.chkChoose.HeaderText = "";
            this.chkChoose.MinimumWidth = 6;
            this.chkChoose.Name = "chkChoose";
            this.chkChoose.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkChoose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkChoose.Width = 30;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STT.Width = 50;
            // 
            // KyHieu
            // 
            this.KyHieu.DataPropertyName = "KyHieu";
            this.KyHieu.HeaderText = "Ký hiệu";
            this.KyHieu.MinimumWidth = 6;
            this.KyHieu.Name = "KyHieu";
            this.KyHieu.ReadOnly = true;
            this.KyHieu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.KyHieu.Width = 80;
            // 
            // MaNhomHP
            // 
            this.MaNhomHP.DataPropertyName = "MaNhomHP";
            this.MaNhomHP.HeaderText = "Mã nhóm HP";
            this.MaNhomHP.MinimumWidth = 6;
            this.MaNhomHP.Name = "MaNhomHP";
            this.MaNhomHP.ReadOnly = true;
            this.MaNhomHP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNhomHP.Width = 80;
            // 
            // MSCB
            // 
            this.MSCB.DataPropertyName = "MSCB";
            this.MSCB.HeaderText = "Mã cán bộ GD";
            this.MSCB.MinimumWidth = 6;
            this.MSCB.Name = "MSCB";
            this.MSCB.ReadOnly = true;
            this.MSCB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MSCB.Width = 80;
            // 
            // TenHP
            // 
            this.TenHP.DataPropertyName = "TenHP";
            this.TenHP.HeaderText = "Tên học phần";
            this.TenHP.MinimumWidth = 6;
            this.TenHP.Name = "TenHP";
            this.TenHP.ReadOnly = true;
            this.TenHP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenHP.Width = 250;
            // 
            // Thu
            // 
            this.Thu.DataPropertyName = "Thu";
            this.Thu.HeaderText = "Thứ";
            this.Thu.MinimumWidth = 6;
            this.Thu.Name = "Thu";
            this.Thu.ReadOnly = true;
            this.Thu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thu.Width = 60;
            // 
            // TietBD
            // 
            this.TietBD.DataPropertyName = "TietBD";
            this.TietBD.HeaderText = "Tiết BĐ";
            this.TietBD.MinimumWidth = 6;
            this.TietBD.Name = "TietBD";
            this.TietBD.ReadOnly = true;
            this.TietBD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TietBD.Width = 60;
            // 
            // SoTiet
            // 
            this.SoTiet.DataPropertyName = "SoTiet";
            this.SoTiet.HeaderText = "Số tiết";
            this.SoTiet.MinimumWidth = 6;
            this.SoTiet.Name = "SoTiet";
            this.SoTiet.ReadOnly = true;
            this.SoTiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoTiet.Width = 60;
            // 
            // TenPH
            // 
            this.TenPH.DataPropertyName = "TenPH";
            this.TenPH.HeaderText = "Phòng học";
            this.TenPH.MinimumWidth = 6;
            this.TenPH.Name = "TenPH";
            this.TenPH.ReadOnly = true;
            this.TenPH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenPH.Width = 80;
            // 
            // SiSo
            // 
            this.SiSo.DataPropertyName = "SiSo";
            this.SiSo.HeaderText = "Sĩ số";
            this.SiSo.MinimumWidth = 6;
            this.SiSo.Name = "SiSo";
            this.SiSo.ReadOnly = true;
            this.SiSo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SiSo.Width = 60;
            // 
            // ViPham
            // 
            this.ViPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ViPham.DataPropertyName = "ViPham";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ViPham.DefaultCellStyle = dataGridViewCellStyle1;
            this.ViPham.HeaderText = "Vi phạm";
            this.ViPham.MinimumWidth = 6;
            this.ViPham.Name = "ViPham";
            this.ViPham.ReadOnly = true;
            this.ViPham.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // chkChooseAll
            // 
            this.chkChooseAll.AutoSize = true;
            this.chkChooseAll.Location = new System.Drawing.Point(92, 202);
            this.chkChooseAll.Name = "chkChooseAll";
            this.chkChooseAll.Size = new System.Drawing.Size(18, 17);
            this.chkChooseAll.TabIndex = 79;
            this.chkChooseAll.UseVisualStyleBackColor = true;
            this.chkChooseAll.CheckedChanged += new System.EventHandler(this.chkChooseAll_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 838);
            this.panel1.TabIndex = 80;
            this.panel1.Visible = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(0, 289);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(48, 48);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(0, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(48, 58);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(0, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 48);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(0, 117);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(48, 48);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(0, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 48);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTKB
            // 
            this.dgvTKB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dgvTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkChoose,
            this.STT,
            this.KyHieu,
            this.MaNhomHP,
            this.MSCB,
            this.TenHP,
            this.Thu,
            this.TietBD,
            this.SoTiet,
            this.TenPH,
            this.SiSo,
            this.ViPham});
            this.dgvTKB.Location = new System.Drawing.Point(34, 175);
            this.dgvTKB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTKB.Name = "dgvTKB";
            this.dgvTKB.RowHeadersWidth = 51;
            this.dgvTKB.Size = new System.Drawing.Size(1004, 651);
            this.dgvTKB.TabIndex = 1;
            this.dgvTKB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTKB_CellContentClick);
            // 
            // frmTKBHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 838);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkChooseAll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblthongbao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSoTC);
            this.Controls.Add(this.lblMaHP);
            this.Controls.Add(this.lblTenHP);
            this.Controls.Add(this.cboChonHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTKB);
            this.Controls.Add(this.lblkytu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTKBHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thời khóa biểu học phần";
            this.Load += new System.EventHandler(this.frmTKBHocPhan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChonHP;
        private System.Windows.Forms.Label lblTenHP;
        private System.Windows.Forms.Label lblMaHP;
        private System.Windows.Forms.Label lblSoTC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblViPham;
        private System.Windows.Forms.Label lblkytu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSoNhomHopLe;
        private System.Windows.Forms.Label lblSoNhomVP;
        private System.Windows.Forms.Label lblthongbao;
        public System.Windows.Forms.DataGridView dgvTKB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KyHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhomHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TietBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViPham;
        private System.Windows.Forms.CheckBox chkChooseAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}