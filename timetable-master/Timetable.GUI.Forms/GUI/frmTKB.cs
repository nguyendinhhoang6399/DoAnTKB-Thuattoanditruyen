using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Timetable.GUI.Forms.GA;
using Timetable.GUI.Forms.Model;
using Timetable.GUI.Forms.Service;
using Timetable.SERVER.Protos;
using Excel_12 = Microsoft.Office.Interop.Excel;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;

namespace Timetable.GUI.Forms
{
    public partial class frmTKB : Form
    {
        public frmTKB()
        {
            InitializeComponent();
        }
        public bool flagCheck { set; get; }
        frmTKBHocPhan frmTKBHP;
        frmTKBGiaoVien frmTKBGV;
        frmTKBPhongHoc frmTKBPH;
        frmThongKeTKB fThongKe;
        GA.Timetable timetable;
        private void frmTKB_Load(object sender, EventArgs e)
        {
            cbChonHocKi.Items.Add("1");
            cbChonHocKi.Items.Add("2");
            cbChonHocKi.Items.Add("3");
            cbChonHocKi.SelectedIndex = 0;
           
            for (int i = 0; i < 5; i++)
            {
                int year = DateTime.Now.Year - 2;
                year += i;
                string nk = year + " - " + (year + 1);
                cbChonNienKhoa.Items.Add(nk);
            }
            cbChonNienKhoa.SelectedIndex = 0;
            if (flagCheck)
            {
                panelChonHK.Visible = false;
                btnTKBHocPhan_Click(sender, e);
            }
            else
            {
                string hk = cbChonHocKi.SelectedItem.ToString().Trim();
                HK.namhoc = cbChonNienKhoa.SelectedItem.ToString().Trim();
                HK.hocki = int.Parse(hk);
                timetable = initializeTimetable();
            }
            tooltip(btnExcel, "Xuất file dữ liệu sang Excel");
            tooltip(btnSave, "Lưu dữ liệu vào database");
            tooltip(btnDel, "Xóa tất dữ liệu thời khóa biểu hiện tại");
            tooltip(btnAdd, "Thêm dữ liệu thời khóa biểu mới");
            if (Program.timetable == null)
            {
                btnTKBGV.Enabled = false;
                btnTKBHocPhan.Enabled = false;
                btnTKBPhongHoc.Enabled = false;
            }
        }


        public void ShowTKBHP()
        {
            if (frmTKBHP == null || frmTKBHP.IsDisposed) frmTKBHP = new frmTKBHocPhan();
            if (frmTKBGV != null)
                frmTKBGV.Close();
            if (frmTKBPH != null)
                frmTKBPH.Close();
            if (fThongKe != null)
                fThongKe.Close();
            ShowFormChild(frmTKBHP);
        }

        public void ShowTKBGV()
        {
            if (frmTKBGV == null || frmTKBGV.IsDisposed)
            {
                frmTKBGV = new frmTKBGiaoVien();
            }
            if (frmTKBHP != null)
                frmTKBHP.Close();
            if (frmTKBPH != null)
                frmTKBPH.Close();
            if (fThongKe != null)
                fThongKe.Close();
            ShowFormChild(frmTKBGV);
        }

        public void ShowTKBPH()
        {
            if (frmTKBPH == null || frmTKBPH.IsDisposed)
            {
                frmTKBPH = new frmTKBPhongHoc();
            }
            if (frmTKBHP != null)
                frmTKBHP.Close();
            if (frmTKBGV != null)
                frmTKBGV.Close();
            if (fThongKe != null)
                fThongKe.Close();
            ShowFormChild(frmTKBPH);
        } 
        public void ShowTK()
        {
            if (fThongKe == null || fThongKe.IsDisposed)
            {
                fThongKe = new frmThongKeTKB();
            }
            if (frmTKBHP != null)
                frmTKBHP.Close();
            if (frmTKBGV != null)
                frmTKBGV.Close();
            if (frmTKBPH != null)
                frmTKBPH.Close();
            ShowFormChild(fThongKe);
        }

        private void ShowFormChild(Form frm)
        {
            frm.MdiParent = this;

            frm.Show();
            frm.BringToFront();
            frm.Size = this.Size;
            this.Width += 1;
            this.Width += -1;
        }

        private void btnTKBHocPhan_Click(object sender, EventArgs e)
        {
            btnTKBHocPhan.BackColor = Color.LightBlue;
            btnTKBGV.BackColor = Color.LightGray;
            btnTKBPhongHoc.BackColor = Color.LightGray;
            btnThongKe.BackColor = Color.LightGray;
            ControlButton(true);
            ShowTKBHP();
        }

        private void btnTKBGV_Click(object sender, EventArgs e)
        {
            btnTKBHocPhan.BackColor = Color.LightGray;
            btnTKBGV.BackColor = Color.LightBlue;
            btnTKBPhongHoc.BackColor = Color.LightGray;
            btnThongKe.BackColor = Color.LightGray;

            ControlButton(false);
            ShowTKBGV();
        }

        private void btnTKBPhongHoc_Click(object sender, EventArgs e)
        {
            btnTKBHocPhan.BackColor = Color.LightGray;
            btnTKBGV.BackColor = Color.LightGray;
            btnTKBPhongHoc.BackColor = Color.LightBlue;
            btnThongKe.BackColor = Color.LightGray;

            ControlButton(false);
            ShowTKBPH();
        }


        private void btnThongKe_Click(object sender, EventArgs e)
        {
            btnTKBHocPhan.BackColor = Color.LightGray;
            btnTKBGV.BackColor = Color.LightGray;
            btnTKBPhongHoc.BackColor = Color.LightGray;
            btnThongKe.BackColor = Color.LightBlue;

            ControlButton(false);
            ShowTK();
        }
        private void ControlButton(bool enable)
        {
            btnDel.Enabled = enable;
            btnEdit.Enabled = enable;
        }


        private void btnLietKe_Click(object sender, EventArgs e)
        {
            string hk = cbChonHocKi.SelectedItem.ToString().Trim();
            HK.namhoc = cbChonNienKhoa.SelectedItem.ToString().Trim();
            HK.hocki = int.Parse(hk);
            Timetables tb = TimetableService.timetables(HK.hocki, HK.namhoc);
            if (tb.Tkb.Count > 0)
            {
                Program.timetable.Classes = new Class[tb.Tkb.Count];
                //enabled buttons
                btnTKBGV.Enabled = true;
                btnTKBHocPhan.Enabled = true;
                btnTKBPhongHoc.Enabled = true;
                //
                int index = 0;
                foreach (var item in tb.Tkb)
                {
                    string mahp = timetable.getGroup(item.MaNhomHp).MaHocPhan;
                    var hp = Program.timetable.getModule(mahp);
                    int timeslotid;
                    if (hp.IsScheduled != 0)
                        timeslotid = -1;
                    else
                        timeslotid = TimeslotService.GetTimeslot().Lst.Where(x => x.VThu.IdThu == item.IdThu && x.VTiet.IdTiet == item.IdTiet).FirstOrDefault().TimeslotID;
                    Class cl = new Class(index, item.MaNhomHp, mahp, item.IdCanBo, timeslotid, item.IdPhongHoc, item.SoTiet, item.ViPham);
                    Program.timetable.Classes.SetValue(cl, index);
                    index++;
                }
                btnTKBHocPhan_Click(sender, e);
            }
            else
            {
                if (frmTKBHP != null)
                    frmTKBHP.Close();
                if (frmTKBGV != null)
                    frmTKBGV.Close();
                MessageBox.Show("Không có dữ liệu lưu trữ thời khóa biểu cho học kì này.", "Thông báo");
            }
        }

        private void cbChonHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string hk = cbChonHocKi.SelectedItem.ToString().Trim();
            //hocki = int.Parse(hk);
        }

        private void cbChonNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //namhoc = cbChonNienKhoa.SelectedItem.ToString().Trim();
        }

        private GA.Timetable initializeTimetable()
        {
            // Create timetable
            GA.Timetable timetable = new GA.Timetable();

            // Set up rooms
            timetable.Rooms = PhongHocService.GetListPhongHoc();
            timetable.Professors = CanBoService.GetListCanBo();
            timetable.Teaches = GiangDayService.GetListGiangDay(HK.hocki, HK.namhoc);
            timetable.Modules = HocPhanService.GetListHocPhan();
            timetable.Groups = NhomHocPhanService.GetListNhomHP(HK.hocki, HK.namhoc);
            timetable.Timeslots = TimeslotService.GetTimeslot();
            timetable.ListTBP = TimeslotService.listTBP();
            timetable.ListTBR = TimeslotService.listTBR();
            Program.timetable = timetable;
            return timetable;
        }
        private void InsertTimetable()
        {
            foreach (var item in Program.timetable.Classes)
            {
                int vp;
                if (item.ProfessorId == 0)
                    vp = 8;
                else
                    vp = item.Vipham;
                TimetableData tb = new TimetableData()
                {
                    MaNhomHp = item.GroupId,
                    IdCanBo = item.ProfessorId,
                    IdPhongHoc = item.RoomId,
                    IdThu = Program.timetable.getTimeslot(item.TimeslotId).VThu.IdThu,
                    IdTiet = Program.timetable.getTimeslot(item.TimeslotId).VTiet.IdTiet,
                    IdHocKi = TimeslotService.getHocKi(HK.hocki, HK.namhoc).IdHocKi,
                    SoTiet = item.SoTiet,
                    ViPham = vp
                };
                TimetableService.InsertTimetable(tb);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Timetables timetables = TimetableService.timetables(HK.hocki, HK.namhoc);
            if (timetables.Tkb.Count > 0)
            {
                DialogResult result = MessageBox.Show("Học kì này đã được sắp thời khóa biểu. \n" +
                    "Nhấn OK sẽ thay thế thời khóa đã được lưu ở học kì này.", "Cảnh báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                switch (result)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.OK:
                        {
                            TimetableService.DeleteAllTimetale(HK.hocki, HK.namhoc);
                            InsertTimetable();
                            break;
                        }
                    default:
                        break;
                }
            }
            else
            {
                InsertTimetable();
            }
        }


        public void tooltip(Button button, string caption)
        {
            ToolTip tool = new ToolTip();
            tool.SetToolTip(button, caption);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (frmTKBHP != null)
                try
                {
                    ExportDataGridViewTo_Excel12(frmTKBHP.dgvTKB, "Thời khóa biểu học phần");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            if (frmTKBGV != null)
                try
                {
                    string name = "TKB - " + frmTKBGV.cboGiangVien.Text.Substring(0, 8);
                    ExportDataGridViewTo_Excel12(frmTKBGV.dgvLichGV, name);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            if (frmTKBPH != null)
                try
                {
                    string name = "TKB - " + frmTKBPH.cboPhongHoc.Text;
                    ExportDataGridViewTo_Excel12(frmTKBPH.dgvTKBPhongHoc, name);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
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


        private void frmTKB_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!flagCheck)
                this.Close();
            else
            {
                Timetables timetables = TimetableService.timetables(HK.hocki, HK.namhoc);
                if (timetables.Tkb.Count > 0)
                {
                    this.Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Lưu thời khóa biểu hiện tại? \n" +
                        "Bạn vẫn chưa lưu dữ liệu, nếu thoát ra dữ liệu sẽ mất.", "Cảnh báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                    switch (result)
                    {
                        case DialogResult.Cancel:
                            break;
                        case DialogResult.OK:
                            {
                                InsertTimetable();
                                break;
                            }
                        default:
                            break;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddTKB f = new frmAddTKB();
            f.ShowDialog();
        }

        private void panelChonHK_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (frmTKBHP != null)
                frmTKBHP.btnDelete_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (frmTKBHP != null)
                frmTKBHP.btnEdit_Click(sender, e);
        }

    }
}
