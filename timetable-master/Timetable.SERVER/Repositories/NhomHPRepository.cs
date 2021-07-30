using Core.Common;
using Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.SERVER.Database;
using Timetable.SERVER.Models;
using Timetable.SERVER.Protos;

namespace Timetable.SERVER.Repositories
{
    public class NhomHPRepository
    {
        #region lay danh sach can bo
        public static List<NhomHocPhanModel> TT_DS_NHOMHP(int hocki, string namhoc)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_GET_LIST_NHOM_HP",
                    Params = new
                    {
                        hoc_ki = hocki,
                        nam_hoc = namhoc
                    }
                };
                var response = db.GetList(request).Data.toList<NhomHocPhanModel>();
                return response;
            }
        }
        #endregion
        #region lấy thông tin nhóm học phần
        public static List<NhomHocPhanModel> TT_GET_NHOMHP(int manhomHP)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select * from tt_nhom_hoc_phan where ma_nhom_hp = " + manhomHP
                };
                var response = db.GetList(request).Data.toList<NhomHocPhanModel>();
                return response;
            }
        }
        #endregion

        #region thêm mới nhóm học phần
        public static Response TT_INS_NHOMHP(NhomHPData nhomHP)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_INS_NHOM_HP",
                    Params = new
                    {
                        ma_hoc_phan = nhomHP.MaHocPhan,
                        ten_nhom_hp = nhomHP.TenNhomHp,
                        tong_tiet_hoc = nhomHP.TongTietHoc,
                        tong_buoi_hoc = nhomHP.TongBuoiHoc,
                        si_so = nhomHP.SiSo,
                        id_hoc_ki = nhomHP.IdHocKi
                    }
                };
                var response = db.Execute(request);
                return response;
            }
        }
        #endregion
        #region cập nhật nhóm học phần
        public static Response TT_UPDATE_NHOMHP(NhomHPData nhomHP)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_UPDATE_NHOM_HP",
                    Params = new
                    {
                        ma_nhom_hp = nhomHP.MaNhomHp,
                        ma_hoc_phan = nhomHP.MaHocPhan,
                        ten_nhom_hp = nhomHP.TenNhomHp,
                        tong_tiet_hoc = nhomHP.TongTietHoc,
                        tong_buoi_hoc = nhomHP.TongBuoiHoc,
                        si_so = nhomHP.SiSo,
                        id_hoc_ki = nhomHP.IdHocKi
                    }
                };
                var response = db.Execute(request);
                return response;
            }
        }
        #endregion
        #region xóatất cả nhóm học phần
        public static Response TT_DELETEALL_NHOMHP(int hocki, string namhoc)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_DEL_LIST_NHOM_HP",
                    Params = new
                    {
                        hoc_ki = hocki,
                        nam_hoc = namhoc
                    }
                };
                var response = db.Execute(request);
                return response;
            }
        }
        #endregion

        #region xóa 1 nhóm học phần
        public static Response TT_DEL_NHOMHP(int id)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                   Query = "Delete tt_nhom_hoc_phan where ma_nhom_hp = " + id
                };
                var response = db.Execute(request);
                return response;
            }
        }
        #endregion
    }
}
