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
    public partial class frDonVi : Form
    {
        public frDonVi()
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
        bool checkEdit = false, checkNew = false;
        private void treeViewDonVi_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewDonVi.SelectedNode.Nodes.Count == 0)
            {
                int idkhoa = int.Parse(treeViewDonVi.SelectedNode.Name);
                foreach (var bm in DonViService.GetDanhSachBoMon(idkhoa).ListDonVi)
                {
                    TreeNode node = new TreeNode();
                    node.Name = bm.MaDonVi.ToString();
                    node.Text = bm.TenDonVi;
                    treeViewDonVi.SelectedNode.Nodes.Add(node);
                }

            }
            string index = treeViewDonVi.SelectedNode.Name;
            if (index.Equals(""))
                LoadDSDonVi(0);
            else
            {
                int id = int.Parse(index);
                LoadDSDonVi(id);
            }
        }

        private void frDonVi_Load(object sender, EventArgs e)
        {
            int index = 0;
            treeViewDonVi.Nodes.Add("Đại học Giao Thông Vận Tải");
            foreach (var khoa in DonViService.GetDanhSachDonVi(1).ListDonVi)
            {
                TreeNode node = new TreeNode();
                node.Name = khoa.MaDonVi.ToString();
                node.Text = khoa.TenDonVi;
                treeViewDonVi.Nodes[0].Nodes.Add(node);
            }
            cboDonViCha.DataSource = DonViService.GetDanhSachDonVi(1).ListDonVi;
            cboDonViCha.DisplayMember = "TenDonVi";
            cboDonViCha.ValueMember = "MaDonVi";

            List<Item> listLoaiDV = new List<Item>();
            listLoaiDV.Add(new Item() { code = "", id = 1, name = "Khoa" });
            listLoaiDV.Add(new Item() { code = "", id = 2, name = "Bộ môn" });
            listLoaiDV.Add(new Item() { code = "", id = 3, name = "Văn phòng Khoa" });
            cboLoaiDonVi.DataSource = listLoaiDV;
            cboLoaiDonVi.DisplayMember = "name";
            cboLoaiDonVi.ValueMember = "id";

            cboDonViCha.SelectedIndex = -1;
            cboLoaiDonVi.SelectedIndex = -1;
        }
        private void LoadDSDonVi(int id)
        {
            if (id == 0)
            {
                dgvDonVi.DataSource = DonViService.GetDanhSachDonVi().ListDonVi;
            }
            else
            {
                DanhSachDonVi ds = new DanhSachDonVi();
                ds.ListDonVi.Add(DonViService.GetInfoDonVi(id));
                if (DonViService.GetDanhSachBoMon(id).ListDonVi.Count > 0)
                    ds.ListDonVi.AddRange(DonViService.GetDanhSachBoMon(id).ListDonVi);
                dgvDonVi.DataSource = ds.ListDonVi;
            }
        }

        private void dgvDonVi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(checkEdit || checkNew)
            {
                checkEdit = false;
                checkNew = false;
                ControlButton();
            }    
            int iddv = int.Parse(dgvDonVi[0, dgvDonVi.CurrentRow.Index].Value.ToString().Trim());
            DonViData dv = DonViService.GetInfoDonVi(iddv);
            if (dv != null)
            {
                txtMaDinhDanh.Text = dv.MaDinhDanh;
                txtTenDonVi.Text = dv.TenDonVi;
                txtEmail.Text = dv.Email;
                txtFax.Text = dv.Fax;
                txtGioithieu.Text = dv.GioiThieu;
                txtSDT.Text = dv.Sdt;
                txtThanhLap.Text = dv.NgayThanhLap;
                txtDomain.Text = dv.Domain;
                txtDiaChi.Text = dv.DiaChi;
                if (dv.MaDonViCha != 0)
                {
                    DonViData dvcha = DonViService.GetInfoDonVi(dv.MaDonViCha);
                    cboDonViCha.Text = dvcha.TenDonVi;
                }
                else
                    cboDonViCha.Text = "Đại học Giao Thông Vận Tải";
                if (dv.IdLoaiDonVi == 1)
                    cboLoaiDonVi.Text = "Khoa";
                else if (dv.IdLoaiDonVi == 2)
                    cboLoaiDonVi.Text = "Bộ môn";
                else
                    cboLoaiDonVi.Text = "Văn phòng Khoa";

            }

        }

        private void ControlButton()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = !btnDelete.Enabled;
            btnEdit.Enabled = !btnEdit.Enabled;
            btnExcel.Enabled = true;
            btnSave.Enabled = !btnSave.Enabled;
            btnCancel.Enabled = !btnCancel.Enabled;

            txtTenDonVi.ReadOnly = !txtMaDinhDanh.ReadOnly;
            txtSDT.ReadOnly = !txtMaDinhDanh.ReadOnly;
            txtFax.ReadOnly = !txtMaDinhDanh.ReadOnly;
            txtEmail.ReadOnly = !txtMaDinhDanh.ReadOnly;
            txtThanhLap.ReadOnly = !txtMaDinhDanh.ReadOnly;
            txtDomain.ReadOnly = !txtMaDinhDanh.ReadOnly;
            txtGioithieu.ReadOnly = !txtMaDinhDanh.ReadOnly;
            txtDiaChi.ReadOnly = !txtDiaChi.ReadOnly;
            txtMaDinhDanh.ReadOnly = !txtMaDinhDanh.ReadOnly;
            cboLoaiDonVi.Enabled = !cboLoaiDonVi.Enabled;
            cboDonViCha.Enabled = !cboDonViCha.Enabled;
            if(checkNew)
            {
                txtTenDonVi.Clear();
                txtSDT.Clear();
                txtFax.Clear();
                txtEmail.Clear();
                txtThanhLap.Clear();
                txtDomain.Clear();
                txtGioithieu.Clear();
                txtDiaChi.Clear();
                txtMaDinhDanh.Clear();
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ControlButton();
            checkEdit = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkNew = true;
            ControlButton();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            checkEdit = false;
            checkNew = false;
            ControlButton();
         
        }
    }
}
