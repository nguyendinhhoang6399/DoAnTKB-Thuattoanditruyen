using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.SERVER.Models
{
    public class ChucVuModel
    {
        public int ma_chuc_vu { set; get; }
        public string ten_chuc_vu { set; get; }
        public string mo_ta { set; get; }
    }

    public class CongTacModel
    {
        public int ma_cong_tac { set; get; }
        public int ma_chuc_vu { set; get; }
        public int id_can_bo { set; get; }
        public int ma_don_vi { set; get; }
        public string ngay_bat_dau { set; get; }
        public string ngay_ket_thuc { set; get; }
    }
}
