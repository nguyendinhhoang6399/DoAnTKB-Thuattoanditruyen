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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCanBoData_Click(object sender, EventArgs e)
        {
            frmMainParent f = new frmMainParent();
           
            f.btnCanBo_Click(sender, e);
            f.ShowDialog();
            ControlButton();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(DangNhap.cb!=null)
            {
                lblName.Text = DangNhap.cb.Tencanbo;
                lblName.Location = new Point((315), 15);
            }    
            else
            {
                lblName.Text = "Đăng nhập";
            }    
        }

        private void btnKHHTData_Click(object sender, EventArgs e)
        {
            frmMainParent f = new frmMainParent();
            f.btnKHHT_Click(sender, e);
            f.ShowDialog();
            ControlButton();

        }

        private void btnTKB_Click(object sender, EventArgs e)
        {
            frmTKB fr = new frmTKB();
            fr.flagCheck = false;
            fr.ShowDialog();
        }

        private void btnSapXepTKB_Click(object sender, EventArgs e)
        {
            frSapXepTKB frm = new frSapXepTKB();
            frm.ShowDialog();
        }

        private void btnNhomHP_Click(object sender, EventArgs e)
        {
            frmMainParent f = new frmMainParent();
            f.btnNhomHocPhan_Click(sender, e);
            f.ShowDialog();
            ControlButton();
        }

        private void btnDonViData_Click(object sender, EventArgs e)
        {
            frmMainParent f = new frmMainParent();
            f.btnDonVi_Click(sender, e);
            f.ShowDialog();
            ControlButton();
        }

        private void btnHocPhanData_Click(object sender, EventArgs e)
        {
            frmMainParent f = new frmMainParent();
            f.btnHocPhan_Click(sender, e);
            f.ShowDialog();
            ControlButton();
        }

        private void btnPhongHocData_Click(object sender, EventArgs e)
        {
            frmMainParent f = new frmMainParent();
            f.btnPhongHoc_Click(sender, e);
            f.ShowDialog();
            ControlButton();
        }
        void ControlButton()
        {
            if (DangNhap.cb == null)
            {
                btnCanBoData.Enabled = false;
                btnDonViData.Enabled = false;
                btnGiangDay.Enabled = false;
                btnHocPhanData.Enabled = false;
                btnKHHTData.Enabled = false;
                btnNhomHP.Enabled = false;
                btnPhongHocData.Enabled = false;
                btnSapXepTKB.Enabled = false;
                btnTimeslotData.Enabled = false;
                btnTKB.Enabled = false;

                lblName.Text = "Đăng nhập";
                lblName.Location = new Point(344, 15);
            }
            else
            {
                lblName.Text = DangNhap.cb.Tencanbo;
                lblName.Location = new Point((435 - DangNhap.cb.Tencanbo.Length), 15);
            }
        }

        private void btnGiangDay_Click(object sender, EventArgs e)
        {
            frmMainParent f = new frmMainParent();
            f.btnGiangDay_Click(sender, e);
            f.ShowDialog();
            ControlButton();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(DangNhap.cb!=null)
            {
                DialogResult result = MessageBox.Show("Đăng xuất phiên làm việc hiện tại?", "Đăng xuất!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                switch (result)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.OK:
                        {
                            DangNhap.cb = null;
                            this.Close();
                            break;
                        }
                    default:
                        break;
                }
            } 
            else
            {
                this.Close();
            }    
        }

        private void btnTimeslotData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lỗi!!!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon!");
        }
    }
}
