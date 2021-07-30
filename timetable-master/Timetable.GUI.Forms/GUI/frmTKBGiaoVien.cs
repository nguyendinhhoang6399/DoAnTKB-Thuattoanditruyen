using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Timetable.GUI.Forms.Service;
using Timetable.SERVER.Protos;
using Timetable.GUI.Forms.Model;
using Timetable.GUI.Forms.GA;
using System.Linq;

namespace Timetable.GUI.Forms
{
    public partial class frmTKBGiaoVien : Form
    {
        public frmTKBGiaoVien()
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
        DataTable dtGVLop;
        GA.Timetable timetable;
        public string namhoc { set; get; } = "";
        private void frmTKBGiaoVien_Load(object sender, EventArgs e)
        {

            DanhSachDonVi dsKhoa = DonViService.GetDanhSachDonVi(1);
            List<Item> items = new List<Item>();
            items.Add(new Item() { id = 0, code = "", name = "-----------Chọn Khoa----------" });
            foreach (var i in dsKhoa.ListDonVi)
            {
                items.Add(new Item() { id = i.MaDonVi, code = i.MaDinhDanh, name = i.TenDonVi });
            }
            cboKhoa.DisplayMember = "name";
            cboKhoa.ValueMember = "id";
            cboKhoa.DataSource = items;


            cboKhoa.SelectedIndex = 0;
            cboBoMon.SelectedIndex = 0;

            cboKhoa.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboKhoa.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboBoMon.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboBoMon.AutoCompleteSource = AutoCompleteSource.ListItems;

            LoadCboCanBo(0);
            cboGiangVien.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboGiangVien.AutoCompleteSource = AutoCompleteSource.ListItems;

            LoadTKB(0);
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maDVCha = 0;
            var maKhoa = cboKhoa.SelectedValue;
            if (maKhoa != null)
                if (int.TryParse(maKhoa.ToString().Trim(), out maDVCha))
                {
                    DanhSachDonVi dsBoMon = DonViService.GetDanhSachBoMon(maDVCha);
                    List<Item> items = new List<Item>();
                    items.Add(new Item() { id = 0, code = "", name = "-----------Chọn Bộ Môn----------" });
                    if (dsBoMon != null)
                        foreach (var i in dsBoMon.ListDonVi)
                        {
                            items.Add(new Item() { id = i.MaDonVi, code = i.MaDinhDanh, name = i.TenDonVi });
                        }
                    cboBoMon.DisplayMember = "name";
                    cboBoMon.ValueMember = "id";
                    cboBoMon.DataSource = items;
                   
                }
        }

        private void cboGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int macb;
            if (int.TryParse(cboGiangVien.SelectedValue.ToString(), out macb) && macb != 0)
            {
                LoadTKB(macb);

                var ds = GiangDayService.GetListGiangDay(HK.hocki,HK.namhoc).ListGiangDay.Where(x => x.IdCanBo == macb);
                string chuyenmon = "";
                foreach (var item in ds)
                {
                    chuyenmon = chuyenmon + item.MaHocPhan.Trim() + ", ";
                }
                lblChucVu.Text = "Chức vụ: ";
                lblmacb.Text = "Mã CB: " + timetable.getProfessor(macb).Macanbo;
                lblTen.Text = "Họ Tên: " + timetable.getProfessor(macb).Tencanbo;
                lblChuyenNganh.Text = "Giảng dạy: \n" + chuyenmon;
            }


        }

        private void cboBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maDV = 0;
            var maBoMon = cboBoMon.SelectedValue;
            if (maBoMon != null)
                if (int.TryParse(maBoMon.ToString().Trim(), out maDV))
                {
                    LoadCboCanBo(maDV);
                }
        }

        private void LoadCboCanBo(int madv)
        {
            DanhSachCanBo dsCanbo;
            if (madv != 0)
                dsCanbo = CanBoService.FindCanBoDV(madv);
            else dsCanbo = CanBoService.GetListCanBo();
            List<Item> items = new List<Item>();
            items.Add(new Item() { id = 0, code = "", name = "-----------Chọn cán bộ----------" });
            if (dsCanbo != null)
                foreach (var i in dsCanbo.ListCanBo)
                {
                    items.Add(new Item()
                    {
                        id = i.IdCanBo,
                        code = i.Macanbo,
                        name = i.Macanbo.Trim() + " - " + i.Tencanbo
                    });
                }
            cboGiangVien.DisplayMember = "name";
            cboGiangVien.ValueMember = "id";
            cboGiangVien.DataSource = items;
         
        }

        public void LoadTKB(int macb)
        {
            dtGVLop = new DataTable();
            dtGVLop.Columns.Add("STT", System.Type.GetType("System.String"));
            dtGVLop.Columns.Add("KyHieu", System.Type.GetType("System.String"));
            dtGVLop.Columns.Add("MaNhomHP", System.Type.GetType("System.String"));
            dtGVLop.Columns.Add("MaHP", System.Type.GetType("System.String"));
            dtGVLop.Columns.Add("Thu", System.Type.GetType("System.String"));
            dtGVLop.Columns.Add("TietBD", System.Type.GetType("System.String"));
            dtGVLop.Columns.Add("SoTiet", System.Type.GetType("System.String"));
            dtGVLop.Columns.Add("TenPH", System.Type.GetType("System.String"));
            dtGVLop.Columns.Add("SiSo", System.Type.GetType("System.String"));
            dtGVLop.Columns.Add("ViPham", System.Type.GetType("System.String"));

            dgvLichGV.DataSource = dtGVLop;
            dgvLichGV.Columns["STT"].HeaderText = "STT";
            dgvLichGV.Columns["KyHieu"].HeaderText = "Ký Hiệu";
            dgvLichGV.Columns["MaNhomHP"].HeaderText = "Mã Nhóm HP";
            dgvLichGV.Columns["MaHP"].HeaderText = "Mã HP";
            dgvLichGV.Columns["Thu"].HeaderText = "Thứ";
            dgvLichGV.Columns["TietBD"].HeaderText = "Tiết BD";
            dgvLichGV.Columns["SoTiet"].HeaderText = "Số tiết";
            dgvLichGV.Columns["TenPH"].HeaderText = "Phòng học";
            dgvLichGV.Columns["SiSo"].HeaderText = "Sỉ số";
            dgvLichGV.Columns["ViPham"].HeaderText = "VP";

            dgvLichGV.Columns["STT"].Width = 50;
            dgvLichGV.Columns["KyHieu"].Width = 80;
            dgvLichGV.Columns["MaNhomHP"].Width = 100;
            dgvLichGV.Columns["MaHP"].Width = 80;
            dgvLichGV.Columns["Thu"].Width = 80;
            dgvLichGV.Columns["TietBD"].Width = 80;
            dgvLichGV.Columns["SoTiet"].Width = 80;
            dgvLichGV.Columns["TenPH"].Width = 100;
            dgvLichGV.Columns["SiSo"].Width = 80;
            dgvLichGV.Columns["ViPham"].Width = 50;

            timetable = Program.timetable;
            //timetable.createClasses(Program.population.getFittest(0));
            int id = 1;
            if (macb != 0)
            {
                foreach (var item in timetable.Classes)
                {
                    if (item.ProfessorId == macb)
                    {
                        addRow(id.ToString(), item, timetable);
                        id++;
                    }
                }
            }
        }
        public void addRow(string id, Class cl, GA.Timetable timetable1)
        {
            DataRow row = dtGVLop.NewRow();
            row["STT"] = id;
            row["KyHieu"] = cl.GroupId;
            row["MaNhomHP"] = timetable1.getGroup(cl.GroupId).TenNhomHp;
            row["MaHP"] = timetable1.getModule(cl.ModuleId.Trim()).MaHocPhan;
            row["Thu"] = timetable1.getTimeslot(cl.TimeslotId).VThu.Thu_;
            row["TietBD"] = timetable1.getTimeslot(cl.TimeslotId).VTiet.Tiet_;
            row["SoTiet"] = cl.SoTiet;
            row["TenPH"] = timetable1.getRoom(cl.RoomId).TenPhongHoc;
            row["SiSo"] = timetable1.getGroup(cl.GroupId).SiSo;
            row["ViPham"] = cl.Vipham;
            dtGVLop.Rows.Add(row);
        }

        private void dgvLichGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int manhomhp = int.Parse(dgvLichGV[1, dgvLichGV.CurrentRow.Index].Value.ToString());
            string mahp = dgvLichGV[3, dgvLichGV.CurrentRow.Index].Value.ToString();

            lblMaHP.Text = "Mã học phần: " + mahp;
            lblSoTC.Text = "Số tín chỉ: " + timetable.getModule(mahp.Trim()).SoTinChi;
            lblTenHP.Text = "Tên học phần: " + timetable.getModule(mahp.Trim()).TenHocPhan;
        }
    }
}
