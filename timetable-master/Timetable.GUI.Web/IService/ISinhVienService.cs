using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Web.IService
{
    public interface ISinhVienService
    {
        IEnumerable<SinhVienData> GetAllSinhVien();
        SinhVienData GetInfoSinhVien(string masinhvien);
        bool AddSinhVien(SinhVienData sv);
        bool UpdateSinhVien(SinhVienData sv);
        bool DeleteSinhVien(string maSinhVien);
    }
}
