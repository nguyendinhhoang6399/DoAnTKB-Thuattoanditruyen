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
using System.Linq;
using System.Threading;

namespace Timetable.GUI.Forms
{
    public partial class frmAddNhomHP : Form
    {
        public frmAddNhomHP()
        {
            InitializeComponent();
        }
        public string hocki { set; get; } = "1";
        public string namhoc { set; get; } = "";
        private DanhSachNhomHP dsNhomHP { set; get; } = null;

        private void frmAddNhomHP_Load(object sender, EventArgs e)
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



            cboHocKi.Items.Add("1");
            cboHocKi.Items.Add("2");
            cboHocKi.Items.Add("3");
            cboHocKi.SelectedItem = HK.hocki.ToString();
           
            for (int i = 0; i < 3; i++)
            {
                int year = DateTime.Now.Year - 1;
                year += i;
                string nk = year + " - " + (year + 1);
                cboNienKhoa.Items.Add(nk);
            }
            cboNienKhoa.SelectedItem = HK.namhoc;

            cboHocPhan.DataSource = items;
            cboHocPhan.DisplayMember = "name";
            cboHocPhan.ValueMember = "code";
            cboHocPhan.SelectedIndex = 0;
            cboHocPhan.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboHocPhan.AutoCompleteSource = AutoCompleteSource.ListItems;

            Thread thread = new Thread(new ThreadStart(LoadDsNhomHP));
            thread.Start();
        }

        private void cboHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahp = cboHocPhan.SelectedValue.ToString().Trim();
            if (mahp != "" && !mahp.Equals("Timetable.GUI.Forms.Model.Item"))
            {
                HocPhanData hp = HocPhanService.GetHocPhan(mahp);
                NhomHPData nhomhp = dsNhomHP.ListNhomHP.Where(x => x.MaHocPhan == mahp).LastOrDefault();
                if (nhomhp != null)
                {
                    int masonhom = int.Parse(nhomhp.TenNhomHp.Substring(7)) + 1;
                    txtTenNhomHP.Text = hp.MaHocPhan.Trim() + "'" + masonhom.ToString("00");
                }
                else
                    txtTenNhomHP.Text = hp.MaHocPhan.Trim() + "'01";
                txtSoTiet.Text = hp.SoTietMoiTuan.ToString();
                txtSoBuoi.Text = hp.SoBuoiMoiTuan.ToString();
                txtSiSo.Text = hp.SiSo.ToString();
                lblTinChi.Text = hp.SoTinChi + " tín chỉ";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int idhocki = TimeslotService.getHocKi(int.Parse(hocki), namhoc).IdHocKi;
            int sotiet, sobuoi, siso;
            if (!int.TryParse(txtSoTiet.Text, out sotiet) || sotiet <= 0)
                MessageBox.Show("Lỗi nhập dữ liệu số tiết");
            else if (!int.TryParse(txtSoBuoi.Text, out sobuoi) || sobuoi <= 0)
                MessageBox.Show("Lỗi nhập dữ liệu số buổi");
            else if (!int.TryParse(txtSiSo.Text, out siso) || siso <= 0)
                MessageBox.Show("Lỗi nhập dữ liệu sĩ số");
            else
            {
                NhomHPData nhomhp = new NhomHPData()
                {
                    MaHocPhan = cboHocPhan.SelectedValue.ToString().Trim(),
                    TenNhomHp = txtTenNhomHP.Text,
                    TongTietHoc = sotiet,
                    TongBuoiHoc = sobuoi,
                    SiSo = siso,
                    IdHocKi = idhocki,
                    MaNhomHp = 0
                };
                if (NhomHocPhanService.InsertNhomHP(nhomhp))
                    MessageBox.Show("Thêm dữ liệu thành công.");
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void LoadDsNhomHP()
        {
            dsNhomHP = NhomHocPhanService.GetListNhomHP(int.Parse(hocki.Trim()), namhoc);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            namhoc = cboNienKhoa.Text;
        }

        private void cboHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            hocki = cboHocKi.Text;
        }
    }
}
