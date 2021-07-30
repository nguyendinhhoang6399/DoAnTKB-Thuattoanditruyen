using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.SERVER.Models
{
    public class TimetableModel
    {
        public int id_tkb { set; get; }
        public int ma_nhom_hoc_phan{ set; get; }
        public int tiet_bd { set; get; }
        public int thu { set; get; }
        public int id_phong_hoc { set; get; }
        public int id_can_bo { set; get; }
        public int id_hoc_ki { set; get; }
        public int so_tiet { set; get; }
        public int vi_pham { set; get; }
        public string ma_hoc_phan { set; get; }
        public string ten_hoc_phan { set; get; }
        public int so_tin_chi { set; get; }
        public string ten_phong_hoc { set; get; }
        public string ten_nhom_hp { set; get; }


    }
}
