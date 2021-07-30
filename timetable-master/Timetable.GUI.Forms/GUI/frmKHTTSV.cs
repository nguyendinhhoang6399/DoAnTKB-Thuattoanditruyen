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
    public partial class frmKHTTSV : Form
    {
        public frmKHTTSV()
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
        private List<Item> itemsBM;
        private DanhSachKHHT listKHHT { set; get; }
        DanhSachNhomHP listNhomHP { set; get; }
        private string namhoc { set; get; }
        private int hk { set; get; }
        private void frmKHTTSV_Load(object sender, EventArgs e)
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

            cboChonKhoa.DataSource = items;
            cboChonKhoa.DisplayMember = "name";
            cboChonKhoa.ValueMember = "id";
            cboChonKhoa.SelectedIndex = 0;

            cbChonBoMon.Items.Add("-----------Chọn Bộ Môn----------");
            cbChonBoMon.SelectedIndex = 0;

            button1.Enabled = false;
        }

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
                    cbChonBoMon.DataSource = items;
                    cbChonBoMon.DisplayMember = "name";
                    cbChonBoMon.ValueMember = "id";
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hocki = cbChonHocKi.SelectedItem.ToString().Trim();
            namhoc = cbChonNienKhoa.SelectedItem.ToString().Trim();
            hk = int.Parse(hocki);
            listKHHT = KHHTService.Sum_KHHT(hk, namhoc);

            dgvKHTT.DataSource = listKHHT.ListKHHT;
            //dgvKHTT.Columns["IdThkhht"].HeaderText = "ID";
            //dgvKHTT.Columns["MaHocPhan"].HeaderText = "Mã học phần";
            //dgvKHTT.Columns["TenHocPhan"].HeaderText = "Tên học phần";
            //dgvKHTT.Columns["SoTinChi"].HeaderText = "Số tín chỉ";
            //dgvKHTT.Columns["SoTietMoiTuan"].HeaderText = "Số tiết/tuần";
            //dgvKHTT.Columns["SoBuoiMoiTuan"].HeaderText = "Số buổi/tuần";
            //dgvKHTT.Columns["SiSo"].HeaderText = "Sĩ số mỗi nhóm";
            //dgvKHTT.Columns["IdHocKi"].Visible = false;
            //dgvKHTT.Columns["SoLuongDk"].HeaderText = "Số lượng SV đăng kí";

            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listNhomHP = NhomHocPhanService.GetListNhomHP(hk, namhoc);
            if (listNhomHP.ListNhomHP.Count == 0)
            {
                InsertNhomHP();
            }
            else
            {
                DialogResult result = MessageBox.Show("Các học phần này đã được chia nhóm trong học kì này. \n" +
                    "Nhấn tiếp tục sẽ xóa các nhóm đã được chia và sẽ tiến hành chia nhóm lại.", "Cảnh báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                switch (result)
                {
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        {
                            NhomHocPhanService.DeleteAllNhomHP(hk, namhoc);
                            InsertNhomHP();
                            break;
                        }
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Yes:
                        break;
                    default:
                        break;
                }
            }
        }
        public void InsertNhomHP()
        {
            HocPhanData hp = new HocPhanData();
            int sonhom = 0;
            int siso = 0;
            foreach (var item in listKHHT.ListKHHT)
            {
                hp = HocPhanService.GetHocPhan(item.MaHocPhan);
                double check = item.SoLuongDk / (double)hp.SiSo;
                if (check < 1.2)
                {
                    sonhom = 1;
                    if (item.SoLuongDk < 40)
                        siso = 40;
                    else siso = item.SoLuongDk;
                }
                else if (check >= 1.2 && (check % 1.0) >= 0.2)
                {
                    sonhom = (int)check + 1;
                    siso = hp.SiSo;
                }
                else
                {
                    sonhom = (int)check;
                    siso = hp.SiSo;
                }
                int sl = 0;
                for (int i = 1; i <= sonhom; i++)
                {

                    if (i == sonhom && i != 1)
                        siso = setSiSo((item.SoLuongDk - sl));

                    NhomHPData nhomHp = new NhomHPData()
                    {
                        MaHocPhan = item.MaHocPhan,
                        TenNhomHp = item.MaHocPhan + "'" + i.ToString("00"),
                        TongTietHoc = hp.SoTietMoiTuan,
                        TongBuoiHoc = hp.SoBuoiMoiTuan,
                        SiSo = siso,
                        IdHocKi = item.IdHocKi
                    };
                    NhomHocPhanService.InsertNhomHP(nhomHp);
                    sl += hp.SiSo;
                }
            }
            MessageBox.Show("Đã phân nhóm xong.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public int setSiSo(int siso)
        {
            int temp = siso;
            for (int i = 40; i < 300; i += 20)
                if (siso <= i)
                {
                    temp = i;
                    break;
                }

            return temp;
        }

        private void btnXemDSNhomHP_Click(object sender, EventArgs e)
        {
            frmNhomHP frm = new frmNhomHP();
            frm.ShowDialog();
            this.Visible = false;
        }
    }
}
