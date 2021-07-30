using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.SERVER.Models
{
    public class Tiet
    {
        public int id_tiet { set; get; }
        public string tiet_hoc { set; get; }
        public string tg_bat_dau { set; get; }
        public string tg_ket_thuc { set; get; }
        public int so_phut { set; get; }
    }
}
