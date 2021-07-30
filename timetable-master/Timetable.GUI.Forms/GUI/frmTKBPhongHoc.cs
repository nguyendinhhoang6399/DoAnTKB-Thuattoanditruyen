using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Timetable.GUI.Forms.GA;
using Timetable.GUI.Forms.Model;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Forms
{
    public partial class frmTKBPhongHoc : Form
    {
        public frmTKBPhongHoc()
        {
            InitializeComponent();
        }

        DataTable dtHP;
        private GA.Timetable timetable;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void frmTKBPhongHoc_Load(object sender, EventArgs e)
        {
            cboPhongHoc.AutoCompleteSource = AutoCompleteSource.ListItems;

            //auto generate columns
            dgvTKBPhongHoc.AutoGenerateColumns = false;
            LoadTietHoc();

            List<Item> list = new List<Item>();
            int i = 1;
            foreach (var item in Program.timetable.Rooms.ListPhongHoc)
            {
                Item ite = new Item()
                {
                    id = item.IdPhongHoc,
                    code = item.TenPhongHoc,
                    name = "Phòng " + item.TenPhongHoc
                };
                list.Add(ite);
                i++;
            }
            cboPhongHoc.DataSource = list;
            cboPhongHoc.SelectedIndex = 0;
            cboPhongHoc.ValueMember = "id";
            cboPhongHoc.DisplayMember = "name";
            cboPhongHoc.AutoCompleteMode = AutoCompleteMode.Suggest;

        }
        private void dgvTKBPhongHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string valueCell = dgvTKBPhongHoc.CurrentCell.Value.ToString();
            string manhom = "";
            string macanbo = "";
            if (valueCell != "" && valueCell.Substring(0, 5) != "Tiết" && !valueCell.Substring(0, 3).Equals("Thứ"))
            {
                manhom = valueCell.Substring(0, valueCell.IndexOf(" "));
                macanbo = valueCell.Substring(valueCell.IndexOf(" ") + 6);
            }

            LoadThongTin(manhom, macanbo);
        }

        private void LoadThongTin(string manhom, string macanbo)
        {
            if (manhom != "" && macanbo != "")
            {
                NhomHPData nhomhp = timetable.Groups.ListNhomHP.Where(x => x.TenNhomHp == manhom).FirstOrDefault();
                txtHocPhan.Text = nhomhp.MaHocPhan.Trim() + " - " + timetable.getModule(nhomhp.MaHocPhan).TenHocPhan;
                txtNhomHp.Text = manhom;
                txtSiSo.Text = nhomhp.SiSo.ToString();
                txtSoBuoi.Text = nhomhp.TongBuoiHoc.ToString();

                CanBoData cb = timetable.Professors.ListCanBo.Where(x => x.Macanbo == macanbo).First();
                txtCanbo.Text = macanbo + " - " + cb.Tencanbo;
                txtBoMon.Text = "Comingsoon";
                txtEmail.Text = cb.Email;
            }
            else
            {
                txtHocPhan.Clear();
                txtNhomHp.Clear();
                txtSiSo.Clear();
                txtSoBuoi.Clear();
                txtCanbo.Clear();
                txtBoMon.Clear();
                txtEmail.Clear();
            }
        }

        private void LoadTietHoc()
        {
            dgvTKBPhongHoc.Rows.Add(10);
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    if (i == 0)
                    {
                        string tiet = "";
                        if (j != 0 && j <= 5)
                            tiet = "Tiết " + j;
                        if (j > 6)
                            tiet = "Tiết " + (j - 1);
                        dgvTKBPhongHoc[i, j].Value = tiet;
                    }
                    else
                    {
                        dgvTKBPhongHoc[i, j].Value = "";
                        dgvTKBPhongHoc[i, j].Style.BackColor = Color.LightGray;
                    }
                }
                dgvTKBPhongHoc[i, 0].Style.BackColor = Color.White;
                dgvTKBPhongHoc[i, 6].Style.BackColor = Color.White;
            }
        }

        private void LoadDataTKBPhongHoc(int idph)
        {
            int tongLop = 0, vp = 0, hople = 0;
            dgvTKBPhongHoc.Rows.Clear();
            LoadTietHoc();
            if (idph == 0)
                return;
            else
            {
                timetable = Program.timetable;
                foreach (var item in timetable.Classes)
                {
                    if (item.RoomId == idph)
                    {
                        tongLop++;
                        if (item.Vipham != 0)
                            vp++;
                        int thu = timetable.getTimeslot(item.TimeslotId).VThu.IdThu;
                        int tietBD = timetable.getTimeslot(item.TimeslotId).VTiet.IdTiet;
                        for (int i = 0; i < item.SoTiet; i++)
                        {
                            int tiet = 0;
                            if (tietBD <= 5)
                                tiet = tietBD + i;
                            else
                                tiet = tietBD + i + 1;

                            string macanbo = "";
                            if (item.ProfessorId != 0)
                                macanbo = timetable.getProfessor(item.ProfessorId).Macanbo;
                            string nd = timetable.getGroup(item.GroupId).TenNhomHp.Trim() + " |CB: " + macanbo;
                            dgvTKBPhongHoc[thu, tiet].Value = nd;
                            dgvTKBPhongHoc[thu, tiet].Style.BackColor = Color.LightBlue;
                            if (item.Vipham != 0)
                                dgvTKBPhongHoc[thu, tiet].Style.BackColor = Color.Red;

                        }
                    }
                }
            }
            lblSucChua.Text = "Sức chứa: " + timetable.getRoom(idph).SucChua;
            lblSapLich.Text = "Đã sắp lịch: " + tongLop + " lớp";
            lblVipham.Text = "Vi phạm: " + vp + " lớp";
            lblVipham.ForeColor = Color.Red;
            lblTongHopLe.Text = "Hợp lệ: " + (tongLop - vp) + " lớp";
            lblTongHopLe.ForeColor = Color.Blue;
        }
        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = dgvTKBPhongHoc[column, row];
            DataGridViewCell cell2 = dgvTKBPhongHoc[column, row - 1];
            if (cell1.Value == null || cell2.Value == null || cell1.Value.ToString().Equals("") || cell2.Value.ToString().Equals(""))
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }
        private void dgvTKBPhongHoc_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = dgvTKBPhongHoc.AdvancedCellBorderStyle.Top;
            }
        }

        private void dgvTKBPhongHoc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }

        }

        private void cboPhongHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = cboPhongHoc.SelectedValue.ToString();
            if (!temp.Equals("Timetable.GUI.Forms.Model.Item"))
            {
                int idph = int.Parse(temp);
                LoadDataTKBPhongHoc(idph);
            }
        }

    }
}
