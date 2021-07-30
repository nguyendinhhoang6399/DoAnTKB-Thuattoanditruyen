using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Timetable.GUI.Forms.GA;
using Timetable.GUI.Forms.Service;
using Timetable.SERVER.Protos;
using Timetable.GUI.Forms.Model;

namespace Timetable.GUI.Forms
{
    public partial class frmUpdateTKB : Form
    {
        public frmUpdateTKB()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateTKB_Load(object sender, EventArgs e)
        {
            dgvLichCB.Rows.Add(10);
            dgvTietHoc.Rows.Add(10);
            LoadLichCB(dgvLichCB);
            LoadTietHoc(dgvTietHoc);
            LoadLichBanCanBo(classEdit.ProfessorId);
            LoadCboHp();

            //Load cboCanBO
            List<GiangDayData> dsGD = Program.timetable.getListProfessor(classEdit.ModuleId.Trim());
            List<Item> list = new List<Item>();
            foreach (var item in dsGD)
            {
                CanBoData cb = CanBoService.FindCanBo(item.IdCanBo);
                list.Add(new Item() { code = item.MaHocPhan, id = item.IdCanBo, name = cb.Macanbo.Trim() + " - " + cb.Tencanbo });
            }
            cboCanBo.DisplayMember = "name";
            cboCanBo.ValueMember = "id";
            cboCanBo.DataSource = list;

            cboCanBo.SelectedValue = classEdit.ProfessorId;

        }

        public Class classEdit { set; get; }
        private NhomHPData nhomHP { set; get; }
        private int timeslotID { set; get; }

        private void LoadCboHp()
        {
            nhomHP = Program.timetable.getGroup(classEdit.GroupId);
            string item = nhomHP.MaHocPhan + " - Nhóm " + nhomHP.TenNhomHp;
            cboHp.Items.Add(item);
            cboHp.SelectedIndex = 0;
            lblTiet.Text = "Số tiết/tuần: " + nhomHP.TongTietHoc;
            lblBuoi.Text = "Số buổi/tuần: " + nhomHP.TongBuoiHoc;
            lblSiSo.Text = "Sĩ số: " + nhomHP.SiSo;
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
        private void LoadLichBanCanBo(int idcb)
        {
            var listBusyProf = Program.timetable.ListTBP.ListTimeBusyProf_.Where(x => x.IdCanBo == idcb);
            foreach (var item in listBusyProf)
            {
                var time = Program.timetable.Timeslots.Lst.Where(x => x.VThu.IdThu == item.IdThu && x.VTiet.IdTiet == item.IdTiet);
                for (int i = 1; i < 7; i++)
                {
                    for (int j = 0; j < 10; j++)
                        if (dgvTietHoc[i, j].Value.ToString() == time.First().TimeslotID.ToString())
                        {
                            dgvLichCB[i, j].Value = "B";
                            dgvLichCB[i, j].Style.BackColor = Color.Red;

                        }
                }
            }

        }
        private void LoadLichDayCanBo(int idcb)
        {

            var classes = Program.timetable.Classes.Where(x => x.ProfessorId == idcb);
            foreach (var item in classes)
                for (int i = 1; i < 7; i++)
                    for (int j = 0; j < 10; j++)
                        if (dgvTietHoc[i, j].Value.ToString() == item.TimeslotId.ToString())
                            for (int sotiet = 0; sotiet < item.SoTiet; sotiet++)
                            {
                                if (classEdit.TimeslotId == item.TimeslotId && idcb == classEdit.ProfessorId)
                                {
                                    dgvLichCB[i, j + sotiet].Value = "C";
                                    dgvLichCB[i, j + sotiet].Style.BackColor = Color.LightCyan;
                                }
                                else
                                {
                                    dgvLichCB[i, j + sotiet].Value = "S";
                                    dgvLichCB[i, j + sotiet].Style.BackColor = Color.Yellow;
                                }
                            }
        }

        private void cboCanBo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLichCB(dgvLichCB);
            LoadLichBanCanBo((int)cboCanBo.SelectedValue);
            LoadLichDayCanBo((int)cboCanBo.SelectedValue);
        }
        int click = 1;
        private void dgvLichCB_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = dgvLichCB.CurrentCell.RowIndex;
            int colunm = dgvLichCB.CurrentCell.ColumnIndex;
            string val = dgvLichCB.CurrentCell.Value.ToString();

            int sotiet = classEdit.SoTiet;


            cboCanBo_SelectedIndexChanged(sender, e);

            if ((val.Equals("")) && CheckScheduleCB(sotiet, colunm, row))
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
        private void dgvLichCB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            int thu = Program.timetable.getTimeslot(classEdit.TimeslotId).VThu.IdThu;
            int tiet = Program.timetable.getTimeslot(classEdit.TimeslotId).VTiet.IdTiet;
            TimetableData timetable = TimetableService.getTimtableInfo(classEdit.GroupId, tiet, thu);
            if (timetable != null)
            {
                timetable.IdCanBo = int.Parse(cboCanBo.SelectedValue.ToString());
                timetable.IdPhongHoc = int.Parse(cboPhongHoc.SelectedValue.ToString());
                timetable.IdThu = Program.timetable.getTimeslot(timeslotID).VThu.IdThu;
                timetable.IdTiet = Program.timetable.getTimeslot(timeslotID).VTiet.IdTiet;
                timetable.ViPham = ViPham.KhongVP;
                TimetableService.UpdateTimetable(timetable);
            }
            else
            {
                classEdit.RoomId = int.Parse(cboPhongHoc.SelectedValue.ToString());
                classEdit.ProfessorId = int.Parse(cboCanBo.SelectedValue.ToString());
                classEdit.Vipham = ViPham.KhongVP;
                classEdit.TimeslotId = timeslotID;
                Program.timetable.Classes[classEdit.ClassId] = classEdit;
            }
            this.Close();

        }
    }
}
