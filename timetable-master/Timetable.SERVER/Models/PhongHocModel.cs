using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.SERVER.Models
{
    public class PhongHocModel
    {
        public int id_phong_hoc { set; get; }
        public string ten_phong_hoc { set; get; }
        public int suc_chua { set; get; }
        public int id_nha_hoc { set; get; }
    }
}
