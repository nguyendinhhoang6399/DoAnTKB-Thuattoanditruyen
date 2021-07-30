using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Timetable.GUI.Forms.Model;
using Timetable.GUI.Forms.Service;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        string username = "", password = "";

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtUsername.TabIndex = 1;
            txtPassword.TabIndex = 2;
            btnLogin.TabIndex = 3;
            btnCancel.TabIndex = 4;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản hoặc mật khẩu để đăng nhập", "Thông báo");
                txtUsername.Focus();
            }
            else
            {
                 CanBoData cb = CanBoService.Login(username, password);

                //CanBoData cb = CanBoService.FindCanBo(1);
               
                if(cb.IdCanBo==0)
                 {
                     MessageBox.Show("Tên tài khoản hoặc mật khẩu sai.\nVui lòng nhập lại!!!", "Thông báo");
                     txtUsername.Focus();
                 }
                 else
                 {
                     DangNhap.cb = cb;
                     DangNhap.TimeLogin = DateTime.Now;
                     frmMain f = new frmMain();
                     this.Hide();
                     f.ShowDialog();
                     this.Show();
                 }
            }
        }
    }
}
