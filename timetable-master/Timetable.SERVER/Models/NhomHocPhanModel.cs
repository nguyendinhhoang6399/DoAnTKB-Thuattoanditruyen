using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.SERVER.Models
{
    public class NhomHocPhanModel
    {
        public int ma_nhom_hp { set; get; }
        public string ma_hoc_phan { set; get; }
        public string ten_nhom_hp { set; get; }
        public int tong_tiet_hoc { set; get; }
        public int tong_buoi_hoc { set; get; }
        public int si_so { set; get; }
        public int id_hoc_ki { set; get; }
    }
}
