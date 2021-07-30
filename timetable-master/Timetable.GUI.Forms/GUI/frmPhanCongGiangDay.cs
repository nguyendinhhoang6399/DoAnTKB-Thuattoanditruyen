using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Timetable.GUI.Forms.Model;
using System.Windows.Forms;
using Timetable.GUI.Forms.Service;
using Timetable.SERVER.Protos;
using System.Linq;
using System.Threading;
using Excel_12 = Microsoft.Office.Interop.Excel;


namespace Timetable.GUI.Forms
{
    public partial class frmPhanCongGiangDay : Form
    {
        public frmPhanCongGiangDay()
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
        private void frmPhanCongGiangDay_Load(object sender, EventArgs e)
        {
            DanhSachDonVi dsKhoa = DonViService.GetDanhSachDonVi(1);
            List<Item> items = new List<Item>();
            items.Add(new Item() { id = 0, code = "", name = "-----------Chọn Khoa----------" });
            foreach (var i in dsKhoa.ListDonVi)
            {
                items.Add(new Item() { id = i.MaDonVi, code = i.MaDinhDanh, name = i.TenDonVi });
            }

            cbChonHocKi.Items.Add("1");
            cbChonHocKi.Items.Add("2");
            cbChonHocKi.Items.Add("3");
            cbChonHocKi.SelectedIndex = 0;
           
            for (int i = 0; i < 3; i++)
            {
                int year = DateTime.Now.Year - 1;
                year += i;
                string nk = year + " - " + (year + 1);
                cbChonNienKhoa.Items.Add(nk);
            }
            cbChonNienKhoa.SelectedIndex = 0;

            cboChonKhoa.DisplayMember = "name";
            cboChonKhoa.ValueMember = "id";
            cboChonKhoa.DataSource = items;

            cboChonKhoa.SelectedIndex = 0;

            cbChonBoMon.SelectedIndex = 0;

            LoadCboCanBo();

            cboCanBo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCanBo.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboHocPhan.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboHocPhan.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void LoadCboCanBo()
        {
            var listCanBo = CanBoService.GetListCanBo();
            var listItem = new List<Item>();
            foreach (var item in listCanBo.ListCanBo)
            {
                listItem.Add(new Item
                {
                    id = item.IdCanBo,
                    name = item.IdCanBo + " - " + item.Tencanbo,
                    code = item.Macanbo
                });
            }
            cboCanBo.DisplayMember = "name";
            cboCanBo.ValueMember = "id";
            cboCanBo.DataSource = listItem;
            cboCanBo.SelectedIndex = -1;
        }

        private DanhSachKHHT listKHHT { set; get; }
        private DanhSachNhomHP listNhomHP { set; get; }
        private DanhSachGiangDay listGiangDay { set; get; }
        private string namhoc { set; get; }
        private int hk { set; get; }

        private void cboChonKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maDVCha = 0;
            var maKhoa = cboChonKhoa.SelectedValue;
            if (maKhoa != null)
                if (int.TryParse(maKhoa.ToString().Trim(), out maDVCha))
                {
                    DanhSachDonVi dsBoMon = DonViService.GetDanhSachBoMon(maDVCha);
                    List<Item> items = new List<Item>();
                    items.Add(new Item() { id = 0, code = "", name = "-----------Chọn Bộ Môn----------" });
                    foreach (var i in dsBoMon.ListDonVi)
                    {
                        items.Add(new Item() { id = i.MaDonVi, code = i.MaDinhDanh, name = i.TenDonVi });
                    }
                    cbChonBoMon.DisplayMember = "name";
                    cbChonBoMon.ValueMember = "id";
                    cbChonBoMon.DataSource = items;

                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hocki = cbChonHocKi.SelectedItem.ToString().Trim();
            HK.namhoc = namhoc = cbChonNienKhoa.SelectedItem.ToString().Trim();
            HK.hocki = hk = int.Parse(hocki);
            //
            listKHHT = KHHTService.Sum_KHHT(hk, namhoc);
            listNhomHP = NhomHocPhanService.GetListNhomHP(hk, namhoc);
            Thread thread = new Thread(GetListGiangDay);
            thread.Start();
            //
            DataTable dt = new DataTable();

            dt.Columns.Add("IdThkhht", System.Type.GetType("System.String"));
            dt.Columns.Add("MaHocPhan", System.Type.GetType("System.String"));
            dt.Columns.Add("TenHocPhan", System.Type.GetType("System.String"));
            dt.Columns.Add("SoLuongDk", System.Type.GetType("System.String"));
            dt.Columns.Add("SoNhomHP", System.Type.GetType("System.String"));

            dgvKHTT.DataSource = dt;

            List<Item> listHocPhan = new List<Item>();
            foreach (var item in listKHHT.ListKHHT)
            {
                DataRow row = dt.NewRow();
                row["IdThkhht"] = item.IdThkhht.ToString();
                row["MaHocPhan"] = item.MaHocPhan;
                row["TenHocPhan"] = item.TenHocPhan;
                row["SoLuongDk"] = item.SoLuongDk.ToString();
                if (listNhomHP != null)
                {
                    int sonhom = listNhomHP.ListNhomHP.Where(x => x.MaHocPhan.Trim() == item.MaHocPhan.Trim()).Count();
                    row["SoNhomHP"] = sonhom.ToString();
                }
                else
                    row["SoNhomHP"] = 0;
                dt.Rows.Add(row);
                listHocPhan.Add(new Item()
                {
                    id = item.IdHocKi,
                    code = item.MaHocPhan.Trim(),
                    name = item.MaHocPhan.Trim() + " - " + item.TenHocPhan
                });
            }
            cboHocPhan.DisplayMember = "name";
            cboHocPhan.ValueMember = "code";
            cboHocPhan.DataSource = listHocPhan;


        }

        private void btnXemDSNhomHP_Click(object sender, EventArgs e)
        {
            frmNhomHP frm = new frmNhomHP();
            frm.ShowDialog();
        }

        private void cbChonBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvKHTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listGiangDay != null)
            {
                string mahp = dgvKHTT[1, dgvKHTT.CurrentRow.Index].Value.ToString().Trim();
                DataTable dtGD = new DataTable();
                dtGD.Columns.Add("MaCanBo", System.Type.GetType("System.String"));
                dtGD.Columns.Add("TenCanBo", System.Type.GetType("System.String"));
                dtGD.Columns.Add("SoNhomGiangDay", System.Type.GetType("System.String"));

                var list = listGiangDay.ListGiangDay.Where(x => x.MaHocPhan == mahp);
                foreach (var item in list)
                {
                    DataRow row = dtGD.NewRow();
                    row["MaCanBo"] = item.IdCanBo.ToString();
                    row["TenCanBo"] = CanBoService.FindCanBo(item.IdCanBo).Tencanbo;
                    row["SoNhomGiangDay"] = item.SoNhomGiangDay;

                    dtGD.Rows.Add(row);
                }

                dgvGiangDay.DataSource = dtGD;
            }
            cboHocPhan.SelectedValue = dgvKHTT[1, dgvKHTT.CurrentRow.Index].Value.ToString().Trim();
            cboCanBo.SelectedIndex = -1;
            numSoNhom.Value = 0;
            ControlButton(false);
        }
        void GetListGiangDay()
        {
            listGiangDay = GiangDayService.GetListGiangDay(HK.hocki, HK.namhoc);
        }

        private void dgvGiangDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idcanbo = dgvGiangDay[1, dgvGiangDay.CurrentRow.Index].Value.ToString();
            string sonhom = dgvGiangDay[3, dgvGiangDay.CurrentRow.Index].Value.ToString();
            if (idcanbo != "" && sonhom != "")
            {
                cboCanBo.SelectedValue = int.Parse(idcanbo);
                numSoNhom.Value = int.Parse(sonhom);
            }

            ControlButton(false);
        }

        bool checkNew = false, checkEdit = false;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            checkNew = false;
            checkEdit = true;
            numSoNhom.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Xóa các mục đã chọn sẽ không thể khôi phục lại!!", "Cảnh báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
            switch (result)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.OK:
                    {
                        for (int i = (dgvGiangDay.RowCount - 1); i >= 0; i--)
                        {
                            if (Convert.ToBoolean(dgvGiangDay.Rows[i].Cells[0].EditedFormattedValue) == true)
                            {
                                int idcanbo = int.Parse(dgvGiangDay[1, i].Value.ToString());
                                string mahp = dgvKHTT[1, dgvKHTT.CurrentRow.Index].Value.ToString();
                                GiangDayService.DeleteGiangDay(new RequestGD()
                                {
                                    Id = idcanbo,
                                    Maso = mahp,
                                    Hocki = HK.hocki,
                                    Namhoc = HK.namhoc
                                });
                                dgvGiangDay.Rows.Remove(dgvGiangDay.Rows[i]);
                            }

                        }
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkNew)
            {
                GiangDayData gd = new GiangDayData()
                {
                    IdCanBo = int.Parse(cboCanBo.SelectedValue.ToString()),
                    IdHocKi = TimeslotService.getHocKi(HK.hocki, HK.namhoc).IdHocKi,
                    MaHocPhan = cboHocPhan.SelectedValue.ToString().Trim(),
                    SoNhomGiangDay = (int)numSoNhom.Value
                };
                GiangDayService.InsertGiangDay(gd);
            }
            if (checkEdit)
            {
                GiangDayData gd = new GiangDayData()
                {
                    IdCanBo = int.Parse(cboCanBo.SelectedValue.ToString()),
                    IdHocKi = TimeslotService.getHocKi(HK.hocki, HK.namhoc).IdHocKi,
                    MaHocPhan = cboHocPhan.SelectedValue.ToString().Trim(),
                    SoNhomGiangDay = (int)numSoNhom.Value
                };
                GiangDayService.UpdateGiangDay(gd);
            }
            GetListGiangDay();
            dgvKHTT_CellClick(sender, new DataGridViewCellEventArgs(dgvKHTT.CurrentCell.ColumnIndex, dgvKHTT.CurrentCell.RowIndex));
            ControlButton(false);
            checkEdit = false;
            checkNew = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvGiangDay_CellClick(sender, new DataGridViewCellEventArgs(dgvGiangDay.CurrentCell.ColumnIndex, dgvGiangDay.CurrentCell.RowIndex));
            ControlButton(false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkNew = true;
            checkEdit = false;
            cboCanBo.Text = "Chọn cán bộ giảng dạy";
            numSoNhom.Value = 0;
            ControlButton(true);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataGridView dgvXuatExcel = new DataGridView();
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", System.Type.GetType("System.String"));
            dt.Columns.Add("MaHocPhan", System.Type.GetType("System.String"));
            dt.Columns.Add("TenHocPhan", System.Type.GetType("System.String"));
            dt.Columns.Add("MaCanBo", System.Type.GetType("System.String"));
            dt.Columns.Add("TenCanBo", System.Type.GetType("System.String"));
            dt.Columns.Add("SoNhomGiangDay", System.Type.GetType("System.String"));
            if (listKHHT != null)
            {
                int stt = 1;
                foreach (var hp in listKHHT.ListKHHT)
                {
                    var list = listGiangDay.ListGiangDay.Where(x => x.MaHocPhan == hp.MaHocPhan);
                    foreach (var gd in list)
                    {
                        DataRow row = dt.NewRow();
                        row["STT"] = stt.ToString();
                        row["MaHocPhan"] = hp.MaHocPhan;
                        row["TenHocPhan"] = hp.TenHocPhan;
                        row["MaCanBo"] = gd.IdCanBo.ToString();
                        row["TenCanBo"] = CanBoService.FindCanBo(gd.IdCanBo).Tencanbo;
                        row["SoNhomGiangDay"] = gd.SoNhomGiangDay;

                        dt.Rows.Add(row);
                        stt++;
                    }
                }
            }
            dgvXuatExcel.DataSource = dt;
            ExportDataGridViewTo_Excel12(dgvXuatExcel, "Phân công GD HK" + HK.hocki + "-" + HK.namhoc);

        }

        void ControlButton(bool value)
        {
            cboHocPhan.Enabled = value;
            cboCanBo.Enabled = value;
            numSoNhom.Enabled = value;
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


    }
}
