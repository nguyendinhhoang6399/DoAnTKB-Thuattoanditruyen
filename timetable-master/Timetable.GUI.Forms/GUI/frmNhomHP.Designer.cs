namespace Timetable.GUI.Forms
{
    partial class frmNhomHP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhomHP));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbChonHocKi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbChonNienKhoa = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboChonHP = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkChooseAll = new System.Windows.Forms.CheckBox();
            this.dgvNhomHP = new System.Windows.Forms.DataGridView();
            this.chkChoose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaNhomHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdHocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhomHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongBuoiHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTietHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zbtnUpdatee = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHP)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.043166F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.95683F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1248, 695);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 36);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnExportExcel);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.btnEdit);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.cboChonHP);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Location = new System.Drawing.Point(3, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1329, 33);
            this.panel5.TabIndex = 4;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.Location = new System.Drawing.Point(180, 0);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(33, 33);
            this.btnExportExcel.TabIndex = 0;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.cbChonHocKi);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.cbChonNienKhoa);
            this.panel6.Location = new System.Drawing.Point(456, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(542, 33);
            this.panel6.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Liệt kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(160, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Năm học";
            // 
            // cbChonHocKi
            // 
            this.cbChonHocKi.FormattingEnabled = true;
            this.cbChonHocKi.Location = new System.Drawing.Point(70, 2);
            this.cbChonHocKi.Name = "cbChonHocKi";
            this.cbChonHocKi.Size = new System.Drawing.Size(85, 28);
            this.cbChonHocKi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Học kì";
            // 
            // cbChonNienKhoa
            // 
            this.cbChonNienKhoa.FormattingEnabled = true;
            this.cbChonNienKhoa.Location = new System.Drawing.Point(245, 2);
            this.cbChonNienKhoa.Name = "cbChonNienKhoa";
            this.cbChonNienKhoa.Size = new System.Drawing.Size(168, 28);
            this.cbChonNienKhoa.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(147, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(33, 33);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(113, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(33, 33);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(80, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(33, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cboChonHP
            // 
            this.cboChonHP.FormattingEnabled = true;
            this.cboChonHP.Location = new System.Drawing.Point(219, 1);
            this.cboChonHP.Name = "cboChonHP";
            this.cboChonHP.Size = new System.Drawing.Size(231, 28);
            this.cboChonHP.TabIndex = 1;
            this.cboChonHP.SelectedIndexChanged += new System.EventHandler(this.cboChonHP_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(47, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(509, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(337, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Danh sách phân nhóm học phần";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.736264F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.26373F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1242, 647);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 641);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkChooseAll);
            this.panel3.Controls.Add(this.dgvNhomHP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(49, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1190, 641);
            this.panel3.TabIndex = 2;
            // 
            // chkChooseAll
            // 
            this.chkChooseAll.AutoSize = true;
            this.chkChooseAll.Location = new System.Drawing.Point(58, 17);
            this.chkChooseAll.Name = "chkChooseAll";
            this.chkChooseAll.Size = new System.Drawing.Size(18, 17);
            this.chkChooseAll.TabIndex = 0;
            this.chkChooseAll.UseVisualStyleBackColor = true;
            this.chkChooseAll.CheckedChanged += new System.EventHandler(this.chkChooseAll_CheckedChanged);
            // 
            // dgvNhomHP
            // 
            this.dgvNhomHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkChoose,
            this.MaNhomHp,
            this.IdHocKi,
            this.MaHocPhan,
            this.TenNhomHp,
            this.TongBuoiHoc,
            this.TongTietHoc,
            this.SiSo,
            this.zbtnUpdatee});
            this.dgvNhomHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhomHP.Location = new System.Drawing.Point(0, 0);
            this.dgvNhomHP.Name = "dgvNhomHP";
            this.dgvNhomHP.RowHeadersWidth = 51;
            this.dgvNhomHP.Size = new System.Drawing.Size(1190, 641);
            this.dgvNhomHP.TabIndex = 0;
            this.dgvNhomHP.Text = "dataGridView1";
            this.dgvNhomHP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhomHP_CellContentClick);
            this.dgvNhomHP.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNhomHP_CellFormatting);
            // 
            // chkChoose
            // 
            this.chkChoose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.chkChoose.HeaderText = "";
            this.chkChoose.MinimumWidth = 6;
            this.chkChoose.Name = "chkChoose";
            this.chkChoose.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkChoose.Width = 30;
            // 
            // MaNhomHp
            // 
            this.MaNhomHp.DataPropertyName = "MaNhomHp";
            this.MaNhomHp.HeaderText = "ID";
            this.MaNhomHp.MinimumWidth = 6;
            this.MaNhomHp.Name = "MaNhomHp";
            this.MaNhomHp.ReadOnly = true;
            this.MaNhomHp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNhomHp.Width = 125;
            // 
            // IdHocKi
            // 
            this.IdHocKi.DataPropertyName = "IdHocKi";
            this.IdHocKi.HeaderText = "Học kì";
            this.IdHocKi.MinimumWidth = 6;
            this.IdHocKi.Name = "IdHocKi";
            this.IdHocKi.ReadOnly = true;
            this.IdHocKi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdHocKi.Visible = false;
            this.IdHocKi.Width = 125;
            // 
            // MaHocPhan
            // 
            this.MaHocPhan.DataPropertyName = "MaHocPhan";
            this.MaHocPhan.HeaderText = "Mã Học Phần";
            this.MaHocPhan.MinimumWidth = 6;
            this.MaHocPhan.Name = "MaHocPhan";
            this.MaHocPhan.ReadOnly = true;
            this.MaHocPhan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaHocPhan.Width = 125;
            // 
            // TenNhomHp
            // 
            this.TenNhomHp.DataPropertyName = "TenNhomHp";
            this.TenNhomHp.HeaderText = "Tên nhóm học phần";
            this.TenNhomHp.MinimumWidth = 6;
            this.TenNhomHp.Name = "TenNhomHp";
            this.TenNhomHp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenNhomHp.Width = 200;
            // 
            // TongBuoiHoc
            // 
            this.TongBuoiHoc.DataPropertyName = "TongBuoiHoc";
            this.TongBuoiHoc.HeaderText = "Số buổi/tuần";
            this.TongBuoiHoc.MinimumWidth = 6;
            this.TongBuoiHoc.Name = "TongBuoiHoc";
            this.TongBuoiHoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TongBuoiHoc.Width = 125;
            // 
            // TongTietHoc
            // 
            this.TongTietHoc.DataPropertyName = "TongTietHoc";
            this.TongTietHoc.HeaderText = "Số tiết/tuần";
            this.TongTietHoc.MinimumWidth = 6;
            this.TongTietHoc.Name = "TongTietHoc";
            this.TongTietHoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TongTietHoc.Width = 125;
            // 
            // SiSo
            // 
            this.SiSo.DataPropertyName = "SiSo";
            this.SiSo.HeaderText = "Sĩ số nhóm";
            this.SiSo.MinimumWidth = 6;
            this.SiSo.Name = "SiSo";
            this.SiSo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SiSo.Width = 125;
            // 
            // zbtnUpdatee
            // 
            this.zbtnUpdatee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.zbtnUpdatee.HeaderText = "";
            this.zbtnUpdatee.MinimumWidth = 6;
            this.zbtnUpdatee.Name = "zbtnUpdatee";
            this.zbtnUpdatee.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Học kì";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(278, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 28);
            this.comboBox2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 29);
            this.button4.TabIndex = 2;
            this.button4.Text = "Liệt kê";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1248, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 24);
            this.toolStripMenuItem1.Text = "Công cụ";
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(182, 26);
            this.toolStripMenuItemAdd.Text = "Thêm";
            this.toolStripMenuItemAdd.ToolTipText = "Thêm nhóm học phần mới";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.menustripItem_Click);
            // 
            // frmNhomHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 695);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmNhomHP";
            this.Text = "Danh sách nhóm học phần";
            this.Load += new System.EventHandler(this.frmNhomHP_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHP)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboChonHP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvNhomHP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbChonHocKi;
        private System.Windows.Forms.ComboBox cbChonNienKhoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboChonNienKhoa;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhomHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhomHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongBuoiHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTietHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
        private System.Windows.Forms.DataGridViewButtonColumn zbtnUpdatee;
        private System.Windows.Forms.CheckBox chkChooseAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
    }
}