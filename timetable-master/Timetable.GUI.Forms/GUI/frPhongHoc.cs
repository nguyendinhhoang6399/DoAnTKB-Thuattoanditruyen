using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Timetable.GUI.Forms.Service;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Forms
{
    public partial class frPhongHoc : Form
    {
        public frPhongHoc()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }
        DanhSachNhaHoc dsNhahoc = PhongHocService.GetListNhaHoc();
        DanhSachPhongHoc dsPhongHoc = PhongHocService.GetListPhongHoc();
        private void frPhongHoc_Load(object sender, EventArgs e)
        {

            dgvNhaHoc.DataSource = dsNhahoc.ListNhaHoc;
        }

        private void dgvNhaHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idnhahoc = int.Parse(dgvNhaHoc[0, dgvNhaHoc.CurrentRow.Index].Value.ToString());
            var listPH = dsPhongHoc.ListPhongHoc.Where(x => x.IdNhaHoc == idnhahoc);
            dgvPhongHoc.DataSource = listPH.ToList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
