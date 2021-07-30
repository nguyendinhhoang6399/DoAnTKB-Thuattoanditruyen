using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.SERVER.Models
{
    public class DonViModel
    {
        public int ma_don_vi { set; get; }
        public string ma_dinh_danh { set; get; }
        public string ten_don_vi { set; get; }
        public string dia_chi { set; get; }
        public string email { set; get; }
        public string sdt { set; get; }
        public string fax { set; get; }
        public string domain { set; get; }
        public string gioi_thieu { set; get; }
        public int ma_don_vi_cha { set; get; }
        public string ngay_thanh_lap { set; get; }
        public int id_loai_don_vi { set; get; }
    }
}
