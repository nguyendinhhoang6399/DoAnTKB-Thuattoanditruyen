using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Timetable.SERVER.Models
{
    public class GiangDayModel
    {
        public int id_can_bo { set; get; }
        public string ma_hoc_phan { set; get; }
        public int so_nhom_giang_day { set; get; }
        public int id_hoc_ki { set; get; }
    }
}
