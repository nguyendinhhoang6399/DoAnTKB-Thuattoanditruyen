using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Timetable.SERVER.Protos;
using Timetable.GUI.Forms.Model;
using Timetable.GUI.Forms.Service;
using System.Linq;
using Excel_12 = Microsoft.Office.Interop.Excel;


namespace Timetable.GUI.Forms
{
    public partial class frmNhomHP : Form
    {
        public frmNhomHP()
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
        public DanhSachNhomHP listNhomHP { set; get; }
        public bool flagCheck { set; get; }
        private void frmNhomHP_Load(object sender, EventArgs e)
        {
            DanhSachHocPhan dsHP = HocPhanService.GetListHocPhan();
            List<Item> items = new List<Item>();
            items.Add(new Item() { id = 0, code = "", name = "--------Chọn học phần-------" });
            foreach (var i in dsHP.ListHocPhan)
            {
                items.Add(new Item()
                {
                    id = i.MaDonVi,
                    code = i.MaHocPhan,
                    name = i.MaHocPhan.Trim() + " - " + i.TenHocPhan
                });
            }

            cbChonHocKi.Items.Add("1");
            cbChonHocKi.Items.Add("2");
            cbChonHocKi.Items.Add("3");
            cbChonHocKi.SelectedIndex = 0;
            int year = DateTime.Now.Year;
            for (int i = 0; i < 3; i++)
            {
                year += i;
                string nk = year + " - " + (year + 1);
                cbChonNienKhoa.Items.Add(nk);
            }
            cbChonNienKhoa.SelectedIndex = 0;

            cboChonHP.DataSource = items;
            cboChonHP.DisplayMember = "name";
            cboChonHP.ValueMember = "code";
            cboChonHP.SelectedIndex = 0;
            cboChonHP.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboChonHP.AutoCompleteSource = AutoCompleteSource.ListItems;

            if (flagCheck)
            {
                panel6.Visible = false;
                LoadNhomHP(listNhomHP);
            }
            dgvNhomHP.Columns["zbtnUpdatee"].DefaultCellStyle.NullValue = "Cập nhật";
            dgvNhomHP.Columns["zbtnUpdatee"].DefaultCellStyle.BackColor = Color.RoyalBlue;
            dgvNhomHP.Columns["zbtnUpdatee"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hocki = cbChonHocKi.SelectedItem.ToString().Trim();
            string namhoc = cbChonNienKhoa.SelectedItem.ToString().Trim();
            int hk = int.Parse(hocki);
            HK.namhoc = namhoc;
            HK.hocki = hk;
            listNhomHP = NhomHocPhanService.GetListNhomHP(hk, namhoc);
            LoadNhomHP(listNhomHP);
        }

        private void cboChonHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahp = cboChonHP.SelectedValue.ToString().Trim();
            if (listNhomHP != null)
                if (mahp != "")
                {
                    DanhSachNhomHP dsnhom = new DanhSachNhomHP();
                    dsnhom.ListNhomHP.AddRange(listNhomHP.ListNhomHP.Where(x => x.MaHocPhan == mahp));
                    LoadNhomHP(dsnhom);
                }
                else
                    LoadNhomHP(listNhomHP);
        }

        private void LoadNhomHP(DanhSachNhomHP list)
        {
            dgvNhomHP.DataSource = list.ListNhomHP;
            dgvNhomHP.Columns["zbtnUpdatee"].DisplayIndex = 8;
            //dgvNhomHP.Columns["MaNhomHp"].HeaderText = "ID";
            //dgvNhomHP.Columns["IdHocKi"].Visible = false;
            //dgvNhomHP.Columns["MaHocPhan"].HeaderText = "Mã học phần";
            //dgvNhomHP.Columns["TenNhomHp"].HeaderText = "Ký hiệu";
            //dgvNhomHP.Columns["TongBuoiHoc"].HeaderText = "Số buổi/tuần";
            //dgvNhomHP.Columns["TongTietHoc"].HeaderText = "Số tiết/tuần";
            //dgvNhomHP.Columns["SiSo"].HeaderText = "Sĩ số nhóm";
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = (dgvNhomHP.RowCount - 1); i >= 0; i--)
            {
                if (Convert.ToBoolean(dgvNhomHP.Rows[i].Cells[0].EditedFormattedValue) == true)
                {
                    int manhomHP = (int)dgvNhomHP[2, i].Value;
                    NhomHPData data = listNhomHP.ListNhomHP.Where(x => x.MaNhomHp == manhomHP).FirstOrDefault();
                    NhomHocPhanService.DeleteNhomHP(manhomHP);
                    listNhomHP.ListNhomHP.Remove(data);
                }

            }
            if (cboChonHP.SelectedIndex == 0)
                button1_Click(sender, e);
            else
                cboChonHP_SelectedIndexChanged(sender, e);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string name = " Danh sách nhóm học phần ";
                ExportDataGridViewTo_Excel12(dgvNhomHP, name);
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

        private void dgvNhomHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvNhomHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhomHP.CurrentCell.ColumnIndex == 1)
            {
                NhomHPData nhomHP = new NhomHPData()
                {
                    MaNhomHp = (int)dgvNhomHP[2, dgvNhomHP.CurrentCell.RowIndex].Value,
                    MaHocPhan = (string)dgvNhomHP[3, dgvNhomHP.CurrentCell.RowIndex].Value,
                    TenNhomHp = (string)dgvNhomHP[4, dgvNhomHP.CurrentCell.RowIndex].Value,
                    TongBuoiHoc = (int)dgvNhomHP[6, dgvNhomHP.CurrentCell.RowIndex].Value,
                    TongTietHoc = (int)dgvNhomHP[5, dgvNhomHP.CurrentCell.RowIndex].Value,
                    SiSo = (int)dgvNhomHP[7, dgvNhomHP.CurrentCell.RowIndex].Value,
                    IdHocKi = (int)dgvNhomHP[8, dgvNhomHP.CurrentCell.RowIndex].Value
                };
                bool result = NhomHocPhanService.UpdateNhomHP(nhomHP);
                if (result)
                    MessageBox.Show("Cập nhật thành công");
                else
                    MessageBox.Show("Lỗi!!");
            }

        }

        private void chkChooseAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChooseAll.Checked)
            {
                for (int i = 0; i < dgvNhomHP.Rows.Count; i++)
                {
                    dgvNhomHP[0, i].Value = true;
                }
            }
            else
                for (int i = 0; i < dgvNhomHP.Rows.Count; i++)
                {
                    dgvNhomHP[0, i].Value = false;
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNhomHP fr = new frmAddNhomHP();
            fr.hocki = cbChonHocKi.Text;
            fr.namhoc = cbChonNienKhoa.Text;
            fr.ShowDialog();
            button1_Click(sender, e);
        }

        public DanhSachNhomHP dsNhomHP()
        {
            return listNhomHP;
        }

        private void dgvNhomHP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
        private void Key_Press(object sender, KeyEventArgs e)
        {
            
        }

        private void menustripItem_Click(object sender, EventArgs e)
        {
                btnAdd_Click(sender, e);
        }
    }
}
