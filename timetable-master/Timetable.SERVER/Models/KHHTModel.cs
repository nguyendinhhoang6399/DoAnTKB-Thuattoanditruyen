using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.SERVER.Models
{
    public class KHHTModel
    {
        public int id_thkhht { set; get; }
        public string ma_hoc_phan { set; get; }
        public int so_luong_dk { set; get; }
        public int id_hoc_ki { set; get; }
        public string ten_hoc_phan { set; get; }
        public int so_tin_chi { set; get; }
        public int so_tiet_moi_tuan { set; get; }
        public int so_buoi_moi_tuan { set; get; }
        public int si_so { set; get; }
        
    } 
    public class KHHTSinhVienModel
    {
        public int id_khht { set; get; }
        public string ma_hoc_phan { set; get; }
        public int id_hoc_ki { set; get; }
        public string ma_sinh_vien { set; get; }
        public int cai_thien { set; get; }
       
    }
}
