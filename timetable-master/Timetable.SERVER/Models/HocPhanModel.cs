using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.SERVER.Models
{
    public class HocPhanModel
    {
        public string ma_hoc_phan { set; get; }
        public string ten_hoc_phan { set; get; }
        public int so_tin_chi { set; get; }
        public int so_tiet_lt { set; get; }
        public int so_tiet_th { set; get; }
        public string tien_quyet { set; get; }
        public int is_scheduled { set; get; }
        public int bat_buoc { set; get; }
        public int ma_don_vi { set; get; }
        public string hoc_ki { set; get; }
        public int so_tiet_moi_tuan { set; get; }
        public int so_buoi_moi_tuan { set; get; }
        public int si_so { set; get; }
    }
}
