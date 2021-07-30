    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Timetable.GUI.Forms.Service;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Forms
{
    public partial class frCanBo : Form
    {
        public frCanBo()
        {
            InitializeComponent();
            Thread threadDT = new Thread(LoadDSDanToc);
            threadDT.Start();
            Thread threadTG = new Thread(LoadDSTonGiao);
            threadTG.Start();
        }
        public DanhSachCanBo dsCanbo { set; get; }
        private DanhSachDanToc dsDanToc { set; get; }
        private DanhSachTonGiao dsTonGiao { set; get; }
        DataTable dtKQ, dtCongTac, dtBangCap, dtChuyenMon;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }
        private void frCanBo_Load(object sender, EventArgs e)
        {
            dsCanbo = CanBoService.GetListCanBo();
            dtKQ = new DataTable();
            dgvCanBo.DataSource = dtKQ;
           
            dtKQ.Columns.Add("Macanbo", System.Type.GetType("System.String"));
            dtKQ.Columns.Add("Tencanbo", System.Type.GetType("System.String"));
            dtKQ.Columns.Add("Gioitinh", System.Type.GetType("System.String"));
            dtKQ.Columns.Add("Ngaysinh", System.Type.GetType("System.String"));
            dtKQ.Columns.Add("Sdt", System.Type.GetType("System.String"));
            dtKQ.Columns.Add("Email", System.Type.GetType("System.String"));
            dtKQ.Columns.Add("Diachi", System.Type.GetType("System.String"));
            dtKQ.Columns.Add("TonGiao", System.Type.GetType("System.String"));
            dtKQ.Columns.Add("DanToc", System.Type.GetType("System.String"));
            dtKQ.Columns.Add("IdCanBo", System.Type.GetType("System.String"));
            foreach (var item in dsCanbo.ListCanBo)
            {
                AddRow(item);
            }

            if (dsDanToc != null && dsTonGiao != null)
                loadDataCombobox("", "");

            dgvCongTac.Columns["btnLuuCT"].DisplayIndex = 5;
            dgvCongTac.Columns["btnXoaCT"].DisplayIndex = 6;
        }

        private void AddRow(CanBoData item)
        {
            DataRow row = dtKQ.NewRow();
            row["Macanbo"] = item.Macanbo;
            row["Tencanbo"] = item.Tencanbo;
            if (item.Gioitinh == 0)
                row["Gioitinh"] = "Nữ";
            else
                row["Gioitinh"] = "Nam";
            row["Ngaysinh"] = item.Ngaysinh;
            row["Sdt"] = item.Sdt;
            row["Email"] = item.Email;
            row["Diachi"] = item.DiaChi;
            row["TonGiao"] = item.TonGiao.TenTonGiao;
            row["DanToc"] = item.DanToc.TenDanToc;
            row["IdCanBo"] = item.IdCanBo;
            dtKQ.Rows.Add(row);
        }

        private void LoadDSDanToc()
        {
            dsDanToc = CanBoService.GetListDanToc();
        }
        private void LoadDSTonGiao()
        {
            dsTonGiao = CanBoService.GetListTonGiao();
        }
        private void loadDataCombobox(string dt, string tg)
        {
            cboDanToc.DataSource = dsDanToc.ListDanToc;
            cboDanToc.DisplayMember = "TenDanToc";
            cboDanToc.ValueMember = "MaDanToc";
            cboDanToc.Text = dt;

            cboTonGiao.DataSource = dsTonGiao.ListTonGiao;
            cboTonGiao.DisplayMember = "TenTonGiao";
            cboTonGiao.ValueMember = "MaTonGiao";
            cboTonGiao.Text = tg;
        }

        private void dgvCanBo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataCombobox(dgvCanBo[8, dgvCanBo.CurrentRow.Index].Value.ToString(), dgvCanBo[7, dgvCanBo.CurrentRow.Index].Value.ToString());
            txtMaCanBo.Text = dgvCanBo[0, dgvCanBo.CurrentRow.Index].Value.ToString();
            txtHoTen.Text = dgvCanBo[1, dgvCanBo.CurrentRow.Index].Value.ToString();
            txtNgaySinh.Text = dgvCanBo[3, dgvCanBo.CurrentRow.Index].Value.ToString();
            txtSDT.Text = dgvCanBo[4, dgvCanBo.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgvCanBo[5, dgvCanBo.CurrentRow.Index].Value.ToString();
            txtDiaChi.Text = dgvCanBo[6, dgvCanBo.CurrentRow.Index].Value.ToString();
            string gioitinh = dgvCanBo[2, dgvCanBo.CurrentRow.Index].Value.ToString();
            if (gioitinh.Equals("Nam"))
            {
                rdoNam.Checked = true;
                rdoNu.Checked = false;
                rdoKhac.Checked = false; 
                picAvatar.Image = Image.FromFile("C:\\Users\\DINHHOANG99\\Desktop\\project\\timetable-master\\Timetable.GUI.Forms\\Images\\avtTeacherMale.jpg");
                picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if(gioitinh.Equals("Nữ"))
            {
                rdoNam.Checked = false;
                rdoNu.Checked = true;
                rdoKhac.Checked = false;
                picAvatar.Image = Image.FromFile("C:\\Users\\DINHHOANG99\\Desktop\\project\\timetable-master\\Timetable.GUI.Forms\\Images\\avtTeacherFemale.jpg");
                picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }   
            else
            {
                rdoNam.Checked = false;
                rdoNu.Checked = false;
                rdoKhac.Checked = true;
            }

            int idcanbo = int.Parse(dgvCanBo[9, dgvCanBo.CurrentRow.Index].Value.ToString());
            LoadDataCongTac(idcanbo);
        }
        private void LoadDataCongTac(int idcanbo)
        {
            dtCongTac = new DataTable();
            dgvCongTac.DataSource = dtCongTac;
            dtCongTac.Columns.Add("MaCongTac", System.Type.GetType("System.String"));
            dtCongTac.Columns.Add("DonVi", System.Type.GetType("System.String"));
            dtCongTac.Columns.Add("ChucVu", System.Type.GetType("System.String"));
            dtCongTac.Columns.Add("NgayBD", System.Type.GetType("System.String"));
            dtCongTac.Columns.Add("NgayKT", System.Type.GetType("System.String"));
            foreach (var item in CongTacService.GetCongTac(idcanbo).ListCongTac)
            {
                DataRow row = dtCongTac.NewRow();
                row["MaCongTac"] = item.MaCongTac;
                row["DonVi"] = item.Donvis.TenDonVi;
                row["ChucVu"] = item.Chucvu.TenChucVu;               
                row["NgayBD"] = item.NgayBD;
                row["NgayKT"] = item.NgayKT;
                dtCongTac.Rows.Add(row);
            }
            dgvCongTac.Columns["btnLuuCT"].DisplayIndex = 5;
            dgvCongTac.Columns["btnXoaCT"].DisplayIndex = 6;

        }

        private void dgvCanBo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
