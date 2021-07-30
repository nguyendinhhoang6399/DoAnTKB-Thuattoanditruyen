using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.SERVER.Models
{
    public class TimeslotModel
    {
        public int thu { set; get; }
        public int tiet { set; get; }
    }

    public class TimeBusyRoom
    {
        public int id_phong_hoc { set; get; }
        public int id_tiet { set; get; }
        public int id_thu { set; get; }
        public string ly_do { set; get; }
    }

    public class TimeBusyProf
    {
        public int id_can_bo { set; get; }
        public int id_tiet { set; get; }
        public int id_thu { set; get; }
        public string ly_do { set; get; }
    }

    public class HocKiModel
    {
        public int id_hoc_ki { set; get; }
        public int hoc_ki { set; get; }
        public string nam_hoc { set; get; }
        public string tg_bat_dau { set; get; }
        public string tg_ket_thuc { set; get; }
    }
}
