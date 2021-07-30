using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Timetable.GUI.Forms.Service;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Forms
{
    public partial class frHocPhan : Form
    {
        public frHocPhan()
        {
            InitializeComponent();
        }
        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    this.ControlBox = false;
        //    this.WindowState = FormWindowState.Maximized;
        //    this.BringToFront();
        //}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        DanhSachHocPhan dsHocPhan { set; get; }
        DataTable dtHocPhan;
        bool checkEdit = false, checkNew = false;
        DanhSachDonVi dsDonVi { set; get; }

        private void frHocPhan_Load(object sender, EventArgs e)
        {
            LoadDataHocPhan();
            dgvHocPhan.ReadOnly = true;

            dsDonVi = DonViService.GetDanhSachDonVi(2);
            cboDonVi.DisplayMember = "TenDonVi";
            cboDonVi.ValueMember = "MaDonVi";
            cboDonVi.DataSource = dsDonVi.ListDonVi;

        }
        private void LoadDataHocPhan()
        {
            dtHocPhan = new DataTable();
            dtHocPhan.Columns.Add("MaHocPhan", System.Type.GetType("System.String"));
            dtHocPhan.Columns.Add("TenHocPhan", System.Type.GetType("System.String"));
            dtHocPhan.Columns.Add("SoTinChi", System.Type.GetType("System.String"));
            dtHocPhan.Columns.Add("SoTietLt", System.Type.GetType("System.String"));
            dtHocPhan.Columns.Add("SoTietTh", System.Type.GetType("System.String"));
            dtHocPhan.Columns.Add("TienQuyet", System.Type.GetType("System.String"));
            dtHocPhan.Columns.Add("TuChon", System.Type.GetType("System.Boolean"));
            dtHocPhan.Columns.Add("BatBuoc", System.Type.GetType("System.Boolean"));
            dtHocPhan.Columns.Add("HocKi", System.Type.GetType("System.String"));
            dtHocPhan.Columns.Add("SoTietMoiTuan", System.Type.GetType("System.String"));
            dtHocPhan.Columns.Add("SoBuoiMoiTuan", System.Type.GetType("System.String"));
            dtHocPhan.Columns.Add("SiSo", System.Type.GetType("System.String"));
            dtHocPhan.Columns.Add("DonVi", System.Type.GetType("System.String"));

            dgvHocPhan.DataSource = dtHocPhan;

            dsHocPhan = HocPhanService.GetListHocPhan();
            foreach (var item in dsHocPhan.ListHocPhan)
            {
                AddRow(item);
            }
            ControlButton();
        }
        private void AddRow(HocPhanData data)
        {
            DataRow row = dtHocPhan.NewRow();
            row["MaHocPhan"] = data.MaHocPhan;
            row["TenHocPhan"] = data.TenHocPhan;
            row["SoTinChi"] = data.SoTinChi.ToString();
            row["SoTietLt"] = data.SoTietLt.ToString();
            row["SoTietTh"] = data.SoTietTh.ToString();
            row["TienQuyet"] = data.TienQuyet;
            if (data.IsScheduled != 0)
                row["TuChon"] = true;
            else
                row["TuChon"] = false;
            if (data.BatBuoc != 0)
                row["BatBuoc"] = true;
            else
                row["BatBuoc"] = false;
            row["HocKi"] = data.HocKi;
            row["SoTietMoiTuan"] = data.SoTietMoiTuan.ToString();
            row["SoBuoiMoiTuan"] = data.SoBuoiMoiTuan.ToString();
            row["SiSo"] = data.SiSo.ToString();
            row["DonVi"] = data.MaDonVi.ToString();

            dtHocPhan.Rows.Add(row);
        }

        private void dgvHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkEdit || checkNew)
            {
                checkEdit = false;
                checkNew = false;
                ControlButton();
            }
            txtMaHP.Text = dgvHocPhan[0, dgvHocPhan.CurrentRow.Index].Value.ToString();
            txtTenHP.Text = dgvHocPhan[1, dgvHocPhan.CurrentRow.Index].Value.ToString();
            txtSoTC.Value = int.Parse(dgvHocPhan[2, dgvHocPhan.CurrentRow.Index].Value.ToString());
            txtTietLT.Value = int.Parse(dgvHocPhan[3, dgvHocPhan.CurrentRow.Index].Value.ToString());
            txtTietTH.Value = int.Parse(dgvHocPhan[4, dgvHocPhan.CurrentRow.Index].Value.ToString());
            txtTienQuyet.Text = dgvHocPhan[5, dgvHocPhan.CurrentRow.Index].Value.ToString();
            chkTuChon.Checked = (Boolean)dgvHocPhan[6, dgvHocPhan.CurrentRow.Index].Value;
            chkBatBuoc.Checked = (Boolean)dgvHocPhan[7, dgvHocPhan.CurrentRow.Index].Value;
            txtHocKi.Text = dgvHocPhan[8, dgvHocPhan.CurrentRow.Index].Value.ToString();
            txtSoTietTuan.Value = int.Parse(dgvHocPhan[9, dgvHocPhan.CurrentRow.Index].Value.ToString());
            txtSoBuoiTuan.Value = int.Parse(dgvHocPhan[10, dgvHocPhan.CurrentRow.Index].Value.ToString());
            txtSiSo.Value = int.Parse(dgvHocPhan[11, dgvHocPhan.CurrentRow.Index].Value.ToString());
            cboDonVi.SelectedValue = int.Parse(dgvHocPhan[12, dgvHocPhan.CurrentRow.Index].Value.ToString());
        }

        private void txtSoTietTuan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkNew = true; ControlButton();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            checkEdit = true;
            checkNew = false;
            ControlButton();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            checkEdit = false;
            checkNew = false;
            ControlButton();
        }

        private void ControlButton()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = !btnDelete.Enabled;
            btnEdit.Enabled = !btnEdit.Enabled;
            btnExcel.Enabled = true;
            btnSave.Enabled = !btnSave.Enabled;
            btnCancel.Enabled = !btnCancel.Enabled;

            txtMaHP.ReadOnly = !txtTienQuyet.ReadOnly;
            txtTenHP.ReadOnly = !txtTienQuyet.ReadOnly;
            txtSiSo.ReadOnly = !txtTienQuyet.ReadOnly;
            txtSoTC.ReadOnly = !txtTienQuyet.ReadOnly;
            txtNoiDung.ReadOnly = !txtTienQuyet.ReadOnly;
            txtSoBuoiTuan.ReadOnly = !txtTienQuyet.ReadOnly;
            txtSoTietTuan.ReadOnly = !txtTienQuyet.ReadOnly;
            txtTietLT.ReadOnly = !txtTienQuyet.ReadOnly;
            txtTietTH.ReadOnly = !txtTienQuyet.ReadOnly;
            txtHocKi.ReadOnly = !txtTienQuyet.ReadOnly;
            txtTienQuyet.ReadOnly = !txtTienQuyet.ReadOnly;
            cboDonVi.Enabled = !cboDonVi.Enabled;
            if (checkNew)
            {
                txtMaHP.Clear();
                txtTenHP.Clear();
                txtSoTC.Value = 0;
                txtTienQuyet.Clear();
                txtNoiDung.Clear();
                txtHocKi.Clear();
                txtSiSo.Value = 0;
                txtSoTietTuan.Value = 0;
                txtSoBuoiTuan.Value = 0;
                txtTietLT.Value = 0;
                txtTietTH.Value = 0;
            }
        }
    }
}
