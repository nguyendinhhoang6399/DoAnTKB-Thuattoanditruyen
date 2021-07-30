using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Timetable.GUI.Forms.Model;

namespace Timetable.GUI.Forms
{
    public partial class frmMainParent : Form
    {
        public frmMainParent()
        {
            InitializeComponent();
        }

        private void ShowFormChild(Form frm)
        {
            frm.MdiParent = this;

            frm.Show();
            frm.BringToFront();
            frm.Size = this.Size;
            this.Width += 1;
            this.Width += -1;
        }


        private void frmMainParent_Load(object sender, EventArgs e)
        {
            //lblName.Text = "Xin chào " + DangNhap.cb.Tencanbo;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void openTool_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XLS files (*.xls, *.xlt)|*.xls;*.xlt|XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|ODS files (*.ods, *.ots)|*.ods;*.ots|CSV files (*.csv, *.tsv)|*.csv;*.tsv|HTML files (*.html, *.htm)|*.html;*.htm";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }
       
        private void menuStrip1_Click(object sender, EventArgs e)
        {

        }

        public void btnCanBo_Click(object sender, EventArgs e)
        {
            frCanBo f = new frCanBo();
            ShowFormChild(f);
            ActiveButton(btnCanBo);
        }

        public void btnHocPhan_Click(object sender, EventArgs e)
        {
            frHocPhan f = new frHocPhan();
            ShowFormChild(f);
            ActiveButton(btnHocPhan);
        }

        private void ActiveButton(Button btn)
        {
            btnCanBo.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btnHocPhan.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btnDonVi.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btnKHHT.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btnNhomHocPhan.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btnPhongHoc.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btnSapXepTKB.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btnTKB.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));

            btn.BackColor = Color.White;
        }

        public void btnPhongHoc_Click(object sender, EventArgs e)
        {
            frPhongHoc f = new frPhongHoc();
            ShowFormChild(f);
            ActiveButton(btnPhongHoc);
        }

        public void btnDonVi_Click(object sender, EventArgs e)
        {
            frDonVi f = new frDonVi();
            ShowFormChild(f);
            ActiveButton(btnDonVi);
        }

        public void btnNhomHocPhan_Click(object sender, EventArgs e)
        {
            frmNhomHP f = new frmNhomHP();
            ShowFormChild(f);
            ActiveButton(btnNhomHocPhan);
        }

        public void btnGiangDay_Click(object sender, EventArgs e)
        {
            frmPhanCongGiangDay f = new frmPhanCongGiangDay();
            ShowFormChild(f);
            ActiveButton(btnGiangDay);
        }

        private void btnTKB_Click(object sender, EventArgs e)
        {
            frmTKB f = new frmTKB();
            f.ShowDialog();
        }

        public void btnKHHT_Click(object sender, EventArgs e)
        {
            frmKHTTSV f = new frmKHTTSV();
            ShowFormChild(f);
            ActiveButton(btnKHHT);
        }

        private void btnSapXepTKB_Click(object sender, EventArgs e)
        {
            frSapXepTKB f = new frSapXepTKB();
            f.Show();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DangNhap.cb = null;
            this.Close();
        }
    }
}
