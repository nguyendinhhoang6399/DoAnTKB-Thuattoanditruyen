namespace Timetable.GUI.Forms
{
    partial class frmTKB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTKB));
            this.btnTKBHocPhan = new System.Windows.Forms.Button();
            this.btnTKBPhongHoc = new System.Windows.Forms.Button();
            this.btnTKBGV = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.panelChonHK = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChonHocKi = new System.Windows.Forms.ComboBox();
            this.cbChonNienKhoa = new System.Windows.Forms.ComboBox();
            this.btnLietKe = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panelChonHK.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTKBHocPhan
            // 
            this.btnTKBHocPhan.Image = ((System.Drawing.Image)(resources.GetObject("btnTKBHocPhan.Image")));
            this.btnTKBHocPhan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTKBHocPhan.Location = new System.Drawing.Point(909, 4);
            this.btnTKBHocPhan.Name = "btnTKBHocPhan";
            this.btnTKBHocPhan.Size = new System.Drawing.Size(109, 59);
            this.btnTKBHocPhan.TabIndex = 1;
            this.btnTKBHocPhan.Text = "TKB học phần";
            this.btnTKBHocPhan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTKBHocPhan.UseVisualStyleBackColor = true;
            this.btnTKBHocPhan.Click += new System.EventHandler(this.btnTKBHocPhan_Click);
            // 
            // btnTKBPhongHoc
            // 
            this.btnTKBPhongHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnTKBPhongHoc.Image")));
            this.btnTKBPhongHoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTKBPhongHoc.Location = new System.Drawing.Point(1130, 3);
            this.btnTKBPhongHoc.Name = "btnTKBPhongHoc";
            this.btnTKBPhongHoc.Size = new System.Drawing.Size(119, 59);
            this.btnTKBPhongHoc.TabIndex = 1;
            this.btnTKBPhongHoc.Text = "TKB phòng học";
            this.btnTKBPhongHoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTKBPhongHoc.UseVisualStyleBackColor = true;
            this.btnTKBPhongHoc.Click += new System.EventHandler(this.btnTKBPhongHoc_Click);
            // 
            // btnTKBGV
            // 
            this.btnTKBGV.Image = ((System.Drawing.Image)(resources.GetObject("btnTKBGV.Image")));
            this.btnTKBGV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTKBGV.Location = new System.Drawing.Point(1024, 4);
            this.btnTKBGV.Name = "btnTKBGV";
            this.btnTKBGV.Size = new System.Drawing.Size(100, 59);
            this.btnTKBGV.TabIndex = 1;
            this.btnTKBGV.Text = "TKB cán bộ";
            this.btnTKBGV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTKBGV.UseVisualStyleBackColor = true;
            this.btnTKBGV.Click += new System.EventHandler(this.btnTKBGV_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDel.Location = new System.Drawing.Point(172, 1);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(80, 62);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Xóa";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(258, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 62);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 62);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "TKB mới";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThongKe);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.panelChonHK);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnTKBPhongHoc);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnTKBGV);
            this.panel2.Controls.Add(this.btnTKBHocPhan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1347, 69);
            this.panel2.TabIndex = 4;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThongKe.Location = new System.Drawing.Point(1252, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(83, 59);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(86, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 62);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcel.Location = new System.Drawing.Point(344, 1);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(80, 62);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Xuất file";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // panelChonHK
            // 
            this.panelChonHK.Controls.Add(this.label2);
            this.panelChonHK.Controls.Add(this.label1);
            this.panelChonHK.Controls.Add(this.cbChonHocKi);
            this.panelChonHK.Controls.Add(this.cbChonNienKhoa);
            this.panelChonHK.Controls.Add(this.btnLietKe);
            this.panelChonHK.Location = new System.Drawing.Point(426, 22);
            this.panelChonHK.Name = "panelChonHK";
            this.panelChonHK.Size = new System.Drawing.Size(477, 38);
            this.panelChonHK.TabIndex = 2;
            this.panelChonHK.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChonHK_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(157, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học kì";
            // 
            // cbChonHocKi
            // 
            this.cbChonHocKi.FormattingEnabled = true;
            this.cbChonHocKi.Location = new System.Drawing.Point(71, 5);
            this.cbChonHocKi.Name = "cbChonHocKi";
            this.cbChonHocKi.Size = new System.Drawing.Size(85, 28);
            this.cbChonHocKi.TabIndex = 1;
            this.cbChonHocKi.SelectedIndexChanged += new System.EventHandler(this.cbChonHocKi_SelectedIndexChanged);
            // 
            // cbChonNienKhoa
            // 
            this.cbChonNienKhoa.FormattingEnabled = true;
            this.cbChonNienKhoa.Location = new System.Drawing.Point(236, 5);
            this.cbChonNienKhoa.Name = "cbChonNienKhoa";
            this.cbChonNienKhoa.Size = new System.Drawing.Size(149, 28);
            this.cbChonNienKhoa.TabIndex = 1;
            this.cbChonNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cbChonNienKhoa_SelectedIndexChanged);
            // 
            // btnLietKe
            // 
            this.btnLietKe.Location = new System.Drawing.Point(381, 4);
            this.btnLietKe.Name = "btnLietKe";
            this.btnLietKe.Size = new System.Drawing.Size(101, 29);
            this.btnLietKe.TabIndex = 2;
            this.btnLietKe.Text = "Liệt kê";
            this.btnLietKe.UseVisualStyleBackColor = true;
            this.btnLietKe.Click += new System.EventHandler(this.btnLietKe_Click);
            // 
            // frmTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 903);
            this.Controls.Add(this.panel2);
            this.IsMdiContainer = true;
            this.Name = "frmTKB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTKB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTKB_FormClosed);
            this.Load += new System.EventHandler(this.frmTKB_Load);
            this.panel2.ResumeLayout(false);
            this.panelChonHK.ResumeLayout(false);
            this.panelChonHK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTKBHocPhan;
        private System.Windows.Forms.Button btnTKBPhongHoc;
        private System.Windows.Forms.Button btnTKBGV;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChonHK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChonHocKi;
        private System.Windows.Forms.ComboBox cboChonNamhoc;
        private System.Windows.Forms.Button btnLietKe;
        private System.Windows.Forms.ComboBox cbChonNienKhoa;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnThongKe;
    }
}