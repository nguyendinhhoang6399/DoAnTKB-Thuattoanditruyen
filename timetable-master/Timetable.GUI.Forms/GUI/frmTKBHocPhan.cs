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
using Office_12 = Microsoft.Office.Core;
using Excel_12 = Microsoft.Office.Interop.Excel;
using Timetable.GUI.Forms.Service;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Forms
{
    public partial class frmTKBHocPhan : Form
    {
        public frmTKBHocPhan()
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
        DataTable dtHP;
        private GA.Timetable timetable;
        //private DanhSachCanBo dsCanBo = CanBoService.GetListCanBo();
        private void frmTKBHocPhan_Load(object sender, EventArgs e)
        {
            List<Item> list = new List<Item>();
            int i = 1;
            list.Add(new Item() { id = 0, code = "", name = "-------Chọn học phần--------" });
            foreach (var item in Program.timetable.Modules.ListHocPhan)
            {
                Item ite = new Item()
                {
                    id = i,
                    code = item.MaHocPhan.Trim(),
                    name = item.MaHocPhan.Trim() + " - " + item.TenHocPhan
                };
                list.Add(ite);
                i++;
            }
            cboChonHP.DataSource = list;
            cboChonHP.ValueMember = "code";
            cboChonHP.DisplayMember = "name";
            cboChonHP.SelectedIndex = 0;

            cboChonHP.SelectedIndex = 0;
            cboChonHP.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboChonHP.AutoCompleteSource = AutoCompleteSource.ListItems;
            LoadTKB("");
            LoadVP();
        }

        private void cboChonHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTKB(cboChonHP.SelectedValue.ToString());
            var hp = timetable.getModule(cboChonHP.SelectedValue.ToString().Trim());
            if (hp != null)
            {
                lblMaHP.Text = "Mã học phần: " + hp.MaHocPhan;
                lblTenHP.Text = "Tên HP: " + hp.TenHocPhan;
                lblSoTC.Text = "Số tín chỉ: " + hp.SoTinChi.ToString();
            }
        }


        public void LoadTKB(string mahp)
        {
            dtHP = new DataTable();
            dtHP.Columns.Add("STT", System.Type.GetType("System.String"));
            dtHP.Columns.Add("KyHieu", System.Type.GetType("System.String"));
            dtHP.Columns.Add("MaNhomHP", System.Type.GetType("System.String"));
            dtHP.Columns.Add("MSCB", System.Type.GetType("System.String"));
            dtHP.Columns.Add("TenHP", System.Type.GetType("System.String"));
            dtHP.Columns.Add("Thu", System.Type.GetType("System.String"));
            dtHP.Columns.Add("TietBD", System.Type.GetType("System.String"));
            dtHP.Columns.Add("SoTiet", System.Type.GetType("System.String"));
            dtHP.Columns.Add("TenPH", System.Type.GetType("System.String"));
            dtHP.Columns.Add("SiSo", System.Type.GetType("System.String"));
            dtHP.Columns.Add("ViPham", System.Type.GetType("System.String"));

            dgvTKB.DataSource = dtHP;

            timetable = Program.timetable;
            //timetable.createClasses(Program.population.getFittest(0));
            //timetable.calcClashesSum();
            int id = 1;
            int vp = 0;
            if (mahp.Equals(""))
            {
                foreach (var item in timetable.Classes)
                {
                    if (!item.Vipham.Equals(0))
                        vp++;
                    addRow(id.ToString(), item, timetable);
                    id++;
                }
            }
            else
            {
                foreach (var item in timetable.Classes)
                {
                    if (item.ModuleId.Trim().Equals(mahp))
                    {
                        if (!item.Vipham.Equals(0))
                            vp++;
                        addRow(id.ToString(), item, timetable);
                        id++;
                    }
                }
            }
            groupBox2.Text = "Tổng lớp HP: " + (id - 1) + " lớp";
            lblSoNhomHopLe.Text = "Hợp lệ: " + (id - 1 - vp) + " lớp.";
            lblSoNhomVP.Text = "Vi phạm: " + vp + " lớp.";
            if (vp != 0)
            {
                lblthongbao.Text = "Vẫn còn vi phạm!!!";
                lblthongbao.ForeColor = Color.Red;
            }
            else
            {
                lblthongbao.Text = "Hết vi phạm có thể xuất file.";
                lblthongbao.ForeColor = Color.Green;
            }

        }

        public void addRow(string id, Class cl, GA.Timetable timetable1)
        {
            DataRow row = dtHP.NewRow();
            row["STT"] = id;
            row["KyHieu"] = cl.GroupId.ToString();
            //if (cl.ProfessorId != 0)
            //    row["MSCB"] = dsCanBo.ListCanBo.Where(x => x.IdCanBo == cl.ProfessorId).FirstOrDefault().Macanbo;
            //else
            row["TenHP"] = timetable1.getModule(cl.ModuleId.Trim()).TenHocPhan;
            row["MaNhomHP"] = timetable1.getGroup(cl.GroupId).TenNhomHp;
            if (cl.ProfessorId != 0)
                row["MSCB"] = cl.ProfessorId;
            else
                row["MSCB"] = 0;
            if (cl.TimeslotId >= 0)
            {
                row["Thu"] = timetable1.getTimeslot(cl.TimeslotId).VThu.Thu_;
                row["TietBD"] = timetable1.getTimeslot(cl.TimeslotId).VTiet.Tiet_;
                row["SoTiet"] = cl.SoTiet;
                row["TenPH"] = timetable1.getRoom(cl.RoomId).TenPhongHoc;
            }
            else
            {
                row["Thu"] = "";
                row["TietBD"] = "";
                row["SoTiet"] = 0;
                row["TenPH"] = "";
            }

            row["SiSo"] = timetable1.getGroup(cl.GroupId).SiSo;
            if (cl.ProfessorId != 0)
                row["ViPham"] = cl.Vipham;
            else
                row["ViPham"] = 9;

            dtHP.Rows.Add(row);
        }
        public void LoadVP()
        {
            string vipham = Model.ViPham.KhongVP + ": Không vi phạm \n" +
                            Model.ViPham.TrungLichPhong + ": Trùng lịch phòng học \n" +
                            Model.ViPham.TrungLichCanBo + ": Trùng lịch cán bộ \n" +
                            Model.ViPham.VPSucChuaPhong + ": Quá sức chứa phòng học \n" +
                            Model.ViPham.VPBuoiHoc + ": Vi phạm về buổi học \n" +
                            Model.ViPham.VPThoiGianBatDau + ": Vi phạm thời gian bắt đầu học \n" +
                            Model.ViPham.TrungLichBanCB + ": Trùng lịch bận cán bộ \n" +
                            Model.ViPham.TrungLichBanPH + ": Trùng lịch bận phòng học \n" +
                            Model.ViPham.VPSoNhomGiangDay + ": Vi phạm số nhóm phân\n công giảng dạy \n" +
                             "9: Học phần chưa được phân \n     công cán bộ giảng dạy \n";
            lblViPham.Text = vipham;
            lblViPham.ForeColor = Color.Red;
        }

        public static void ExportDataGridViewTo_Excel12(DataGridView myDataGridViewQuantity, string nameSheet)
        {

            Excel_12.Application oExcel_12 = null; //Excel_12 Application 

            Excel_12.Workbook oBook = null; // Excel_12 Workbook 

            Excel_12.Sheets oSheetsColl = null; // Excel_12 Worksheets collection 

            Excel_12.Worksheet oSheet = null; // Excel_12 Worksheet 

            Excel_12.Range oRange = null; // Cell or Range in worksheet 

            Object oMissing = System.Reflection.Missing.Value;


            // Create an instance of Excel_12. 

            oExcel_12 = new Excel_12.Application();


            // Make Excel_12 visible to the user. 

            oExcel_12.Visible = true;


            // Set the UserControl property so Excel_12 won't shut down. 

            oExcel_12.UserControl = true;

            // System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US"); 

            //object file = File_Name;

            //object missing = System.Reflection.Missing.Value;



            // Add a workbook. 

            oBook = oExcel_12.Workbooks.Add(oMissing);

            // Get worksheets collection 

            oSheetsColl = oExcel_12.Worksheets;

            // Get Worksheet "Sheet1" 

            oSheet = (Excel_12.Worksheet)oSheetsColl.get_Item("Sheet1");
            oSheet.Name = nameSheet;




            // Export titles 

            for (int j = 0; j < myDataGridViewQuantity.Columns.Count; j++)
            {

                oRange = (Excel_12.Range)oSheet.Cells[1, j + 1];

                oRange.Value2 = myDataGridViewQuantity.Columns[j].HeaderText;

            }

            // Export data 

            for (int i = 0; i < myDataGridViewQuantity.Rows.Count; i++)
            {

                for (int j = 0; j < myDataGridViewQuantity.Columns.Count; j++)
                {
                    oRange = (Excel_12.Range)oSheet.Cells[i + 2, j + 1];

                    oRange.Value2 = myDataGridViewQuantity[j, i].Value;

                }

            }
            oBook = null;
            oExcel_12.Quit();
            oExcel_12 = null;
            GC.Collect();
        }

        private void chkChooseAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChooseAll.Checked)
            {
                for (int i = 0; i < dgvTKB.Rows.Count; i++)
                {
                    dgvTKB[0, i].Value = true;
                }
            }
            else
                for (int i = 0; i < dgvTKB.Rows.Count; i++)
                {
                    dgvTKB[0, i].Value = false;
                }
        }

        private void dgvTKB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = (dgvTKB.RowCount - 1); i >= 0; i--)
            {
                if (Convert.ToBoolean(dgvTKB.Rows[i].Cells[0].EditedFormattedValue) == true)
                {
                    btnDelete.Enabled = true;
                    break;
                }

            }
            string selectVal = dgvTKB[3, dgvTKB.CurrentRow.Index].Value.ToString();
            string mahp = selectVal.Substring(0, selectVal.IndexOf("'"));
            var hp = timetable.getModule(mahp);
            if (hp != null)
            {
                lblMaHP.Text = "Mã học phần: " + hp.MaHocPhan;
                lblTenHP.Text = "Tên HP: " + hp.TenHocPhan;
                lblSoTC.Text = "Số tín chỉ: " + hp.SoTinChi.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddTKB f = new frmAddTKB();
            f.ShowDialog();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                ExportDataGridViewTo_Excel12(dgvTKB, "Thời khóa biểu");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Xóa các mục đã chọn sẽ không thể khôi phục lại!!", "Cảnh báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
            switch (result)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.OK:
                    {
                        for (int i = (dgvTKB.RowCount - 1); i >= 0; i--)
                        {
                            if (Convert.ToBoolean(dgvTKB.Rows[i].Cells[0].EditedFormattedValue) == true)
                            {
                                int manhomHP = int.Parse(dgvTKB[2, i].Value.ToString());
                                TimetableService.DeleteTimetale(manhomHP);
                                dgvTKB.Rows.Remove(dgvTKB.Rows[i]);
                            }

                        }
                        btnDelete.Enabled = false;
                        break;
                    }
                default:
                    break;
            }


        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            int manhomHP = int.Parse(dgvTKB[2, dgvTKB.CurrentRow.Index].Value.ToString());
            var classCurrent = Program.timetable.Classes.Where(x => x.GroupId == manhomHP);
            frmUpdateTKB f = new frmUpdateTKB();
            f.classEdit = classCurrent.FirstOrDefault();
            f.ShowDialog();
        }
    }
}
