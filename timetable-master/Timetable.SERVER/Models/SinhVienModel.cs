using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.SERVER.Models
{
    public class SinhVienModel
    {
        private string ma_sinh_vien;
        private string ten_sinh_vien;
        private int gioi_tinh;
        private string ngay_sinh;
        private string sdt;
        private string di_dong;
        private string email;
        private string dia_chi;
        private string avatar;
        private string username;
        private string password;
        private string quyen_dac_biet;
        private int is_active;
        private int trang_thai;
        private int ma_dan_toc;
        private int ma_ton_giao;
        private int ma_nganh;

        public string Ma_sinh_vien { get => ma_sinh_vien; set => ma_sinh_vien = value; }
        public string Ten_sinh_vien { get => ten_sinh_vien; set => ten_sinh_vien = value; }
        public int Gioi_tinh { get => gioi_tinh; set => gioi_tinh = value; }
        public string Ngay_sinh { get => ngay_sinh; set => ngay_sinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Di_dong { get => di_dong; set => di_dong = value; }
        public string Email { get => email; set => email = value; }
        public string Dia_chi { get => dia_chi; set => dia_chi = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Quyen_dac_biet { get => quyen_dac_biet; set => quyen_dac_biet = value; }
        public int Is_active { get => is_active; set => is_active = value; }
        public int Trang_thai { get => trang_thai; set => trang_thai = value; }
        public int Ma_dan_toc { get => ma_dan_toc; set => ma_dan_toc = value; }
        public int Ma_ton_giao { get => ma_ton_giao; set => ma_ton_giao = value; }
        public int Ma_nganh { get => ma_nganh; set => ma_nganh = value; }
    }
}
