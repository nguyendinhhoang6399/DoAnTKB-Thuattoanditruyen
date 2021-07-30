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
    public partial class frmAddTKB : Form
    {
        public frmAddTKB()
        {
            InitializeComponent();
            dgvLichCB.Rows.Add(10);
            dgvTietHoc.Rows.Add(10);
        }
        DanhSachNhomHP dsnhomHP { set; get; }
        private int timeslotID { set; get; }
        private int sobuoi { set; get; }
        private NhomHPData selectedNhomHP { set; get; }
        private void frmAddTKB_Load(object sender, EventArgs e)
        {
            LoadLichCB(dgvLichCB);
            LoadTietHoc(dgvTietHoc);
            dsnhomHP = NhomHocPhanService.GetListNhomHP(HK.hocki, HK.namhoc);
            if (Program.timetable.Classes != null)
                foreach (var item in Program.timetable.Classes)
                {
                    var nhomHP = Program.timetable.getGroup(item.GroupId);
                    dsnhomHP.ListNhomHP.Remove(nhomHP);
                }
            if (dsnhomHP.ListNhomHP.Count == 0)
                cboHp.Text = "Tất cả nhóm HP đã được sắp lịch";
            else
            {
                List<Item> list = new List<Item>();
                foreach (var item in dsnhomHP.ListNhomHP)
                {
                    list.Add(new Item() { code = "", id = item.MaNhomHp, name = item.MaHocPhan.Trim() + " - Nhóm " + item.TenNhomHp });
                }
                cboHp.ValueMember = "id";
                cboHp.DisplayMember = "name";
                cboHp.DataSource = list;

            }

        }
        private void LoadLichCB(DataGridView dgv)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0)
                    {
                        string tiet = "";
                        if (j < 5)
                            tiet = "Tiết " + (j + 1);
                        if (j > 5)
                            tiet = "Tiết " + (j);
                        dgv[i, j].Value = tiet;
                    }
                    else
                    {
                        dgv[i, j].Value = "";
                        dgv[i, j].Style.BackColor = Color.LightGray;
                    }
                }
                dgv[i, 5].Value = "----------";
                dgv[i, 5].Style.BackColor = Color.White;
            }
        }
        private void LoadTietHoc(DataGridView dgv)
        {
            int idtiet = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0)
                    {
                        string tiet = "";
                        if (j < 5)
                            tiet = "Tiết " + (j + 1);
                        if (j > 5)
                            tiet = "Tiết " + (j);
                        dgv[i, j].Value = tiet;
                    }
                    else if (j != 5)
                    {

                        dgv[i, j].Value = idtiet.ToString();
                        dgv[i, j].Style.BackColor = Color.LightGray;
                        idtiet++;
                    }
                }
                dgv[i, 5].Value = "";
                dgv[i, 5].Style.BackColor = Color.White;
            }
        }

        private void dgvLichCB_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = dgvLichCB.CurrentCell.RowIndex;
            int colunm = dgvLichCB.CurrentCell.ColumnIndex;
            string val = dgvLichCB.CurrentCell.Value.ToString();
            int manhomhp = int.Parse(cboHp.SelectedValue.ToString());
            NhomHPData nhomHP = Program.timetable.getGroup(manhomhp);
            int sotiet = (nhomHP.TongBuoiHoc == 0) ? 0 : (nhomHP.TongTietHoc / nhomHP.TongBuoiHoc);

            if (nhomHP.TongBuoiHoc == 1 || sobuoi == 0)
            {
                cboCanBo_SelectedIndexChanged(sender, e);
            }

            if (val.Equals("") && CheckScheduleCB(sotiet, colunm, row))
            {
                for (int i = 0; i < sotiet; i++)
                {
                    dgvLichCB[colunm, row + i].Value = "C";
                    dgvLichCB[colunm, row + i].Style.BackColor = Color.LightBlue;

                }
                //Nạp dữ liệu cho cbo phòng học
                DanhSachPhongHoc dsPhongHoc = PhongHocService.GetListPhongHoc();
                foreach (var item in Program.timetable.Classes)
                {
                    var room = Program.timetable.getRoom(item.RoomId);
                    if (nhomHP.SiSo > room.SucChua || item.TimeslotId.ToString() == dgvTietHoc[colunm, row].Value.ToString())
                        dsPhongHoc.ListPhongHoc.Remove(room);
                }

                cboPhongHoc.DisplayMember = "TenPhongHoc";
                cboPhongHoc.ValueMember = "IdPhongHoc";
                cboPhongHoc.DataSource = dsPhongHoc.ListPhongHoc;
                timeslotID = int.Parse(dgvTietHoc[colunm, row].Value.ToString());
            }
            else
            {
                MessageBox.Show("Tiết đã được sắp lịch hoặc bận. \nVui lòng chọn tiết khác.", "Warning");
            }
        }
        private bool CheckScheduleCB(int sotiet, int column, int row)
        {
            for (int i = 0; i < sotiet; i++)
            {
                if (!dgvLichCB[column, row + i].Value.ToString().Equals(""))
                {
                    return false;
                }
            }
            return true;
        }
        private void cboHp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedNhomHP = Program.timetable.getGroup((int)cboHp.SelectedValue);
                List<GiangDayData> dsGD = Program.timetable.getListProfessor(selectedNhomHP.MaHocPhan.Trim());
                List<Item> list = new List<Item>();
                foreach (var item in dsGD)
                {
                    CanBoData cb = CanBoService.FindCanBo(item.IdCanBo);
                    list.Add(new Item() { code = item.MaHocPhan, id = item.IdCanBo, name = cb.Macanbo.Trim() + " - " + cb.Tencanbo });
                }
                if (list.Count == 0)
                {
                    list.Add(new Item() { code = "", id = 0, name = "Học phần chưa được phân công cán bộ giảng dạy" });
                    LoadLichCB(dgvLichCB);
                }
                cboCanBo.DisplayMember = "name";
                cboCanBo.ValueMember = "id";
                cboCanBo.DataSource = list;
                if (dsnhomHP.ListNhomHP.Count != 0)
                {
                    selectedNhomHP = Program.timetable.getGroup((int)cboHp.SelectedValue);
                    lblTiet.Text = "Số tiết/tuần: " + selectedNhomHP.TongTietHoc;
                    lblBuoi.Text = "Số buổi/tuần: " + selectedNhomHP.TongBuoiHoc;
                    lblSiSo.Text = "Sĩ số: " + selectedNhomHP.SiSo;
                    sobuoi = selectedNhomHP.TongBuoiHoc;
                    if (Program.timetable.getModule(selectedNhomHP.MaHocPhan.Trim()).IsScheduled != 0)
                        btnLuu.Enabled = true;
                    else
                        btnLuu.Enabled = false;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cboCanBo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLichCB(dgvLichCB);
            int idCanBo = int.Parse(cboCanBo.SelectedValue.ToString());
            LoadLichBanCanBo(idCanBo);
            foreach (var item in Program.timetable.Classes)
            {
                if (item.ProfessorId == idCanBo)
                {
                    for (int i = 1; i < 7; i++)
                    {
                        for (int j = 0; j < 10; j++)
                            if (dgvTietHoc[i, j].Value.ToString() == item.TimeslotId.ToString())
                            {
                                for (int sotiet = 0; sotiet < item.SoTiet; sotiet++)
                                {
                                    dgvLichCB[i, j + sotiet].Value = "S";
                                    dgvLichCB[i, j + sotiet].Style.BackColor = Color.Yellow;
                                }
                            }
                    }
                }
            }
        }

        private void LoadLichBanCanBo(int idcb)
        {
            foreach (var item in Program.timetable.ListTBP.ListTimeBusyProf_)
            {
                if (idcb == item.IdCanBo)
                    foreach (var time in Program.timetable.Timeslots.Lst)
                        if (item.IdThu == time.VThu.IdThu && item.IdTiet == time.VTiet.IdTiet)
                            for (int i = 1; i < 7; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                    if (dgvTietHoc[i, j].Value.ToString() == time.TimeslotID.ToString())
                                    {
                                        dgvLichCB[i, j].Value = "B";
                                        dgvLichCB[i, j].Style.BackColor = Color.Red;

                                    }
                            }
            }

        }

        private void cboPhongHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idRoom = int.Parse(cboPhongHoc.SelectedValue.ToString());
            PhongHocData ph = Program.timetable.getRoom(idRoom);
            lblSucChua.Text = "Sức chứa: " + ph.SucChua.ToString();
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TimetableData timetable;
            var mahp = cboHp.Text.Substring(0, cboHp.Text.IndexOf(" "));
            var hp = Program.timetable.getModule(mahp);
            if (hp.IsScheduled == 0)
                timetable = new TimetableData()
                {
                    IdCanBo = int.Parse(cboCanBo.SelectedValue.ToString()),
                    IdPhongHoc = int.Parse(cboPhongHoc.SelectedValue.ToString()),
                    IdHocKi = selectedNhomHP.IdHocKi,
                    IdThu = Program.timetable.getTimeslot(timeslotID).VThu.IdThu,
                    IdTiet = Program.timetable.getTimeslot(timeslotID).VTiet.IdTiet,
                    MaNhomHp = selectedNhomHP.MaNhomHp,
                    SoTiet = selectedNhomHP.TongTietHoc / selectedNhomHP.TongBuoiHoc,
                    ViPham = ViPham.KhongVP
                };
            else
                timetable = new TimetableData()
                {

                    IdCanBo = 0,
                    IdPhongHoc = 0,
                    IdHocKi = selectedNhomHP.IdHocKi,
                    IdThu = 0,
                    IdTiet = 0,
                    MaNhomHp = selectedNhomHP.MaNhomHp,
                    SoTiet = 0,
                    ViPham = ViPham.KhongVP
                };

            bool result = TimetableService.InsertTimetable(timetable);
            if (result)
            {
                btnLuu.Enabled = false;
                MessageBox.Show("Nhóm " + selectedNhomHP.TenNhomHp + " đã được thêm vào TKB.", "Thông báo");
                sobuoi--;
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            if (sobuoi == 0)
            {
                dsnhomHP.ListNhomHP.Remove(selectedNhomHP);
                if (dsnhomHP.ListNhomHP.Count == 0)
                {
                    cboHp.DataSource = dsnhomHP.ListNhomHP;
                    cboCanBo.DataSource = dsnhomHP.ListNhomHP;
                    cboPhongHoc.DataSource = dsnhomHP.ListNhomHP;
                }
                frmAddTKB_Load(sender, e);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemNhomHP_Click(object sender, EventArgs e)
        {
            frmAddNhomHP f = new frmAddNhomHP();
            f.ShowDialog();
            this.frmAddTKB_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
