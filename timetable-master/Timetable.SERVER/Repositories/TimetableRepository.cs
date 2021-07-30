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
    public class TimetableRepository
    {
        #region danh sach thoi khoa bieu theo hoc ki, nam hoc
        public static List<TimetableModel> TT_GET_TIMETABLE(int hocki, string namhoc)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_GET_TKB",
                    Params = new
                    {
                        hoc_ki = hocki,
                        nam_hoc = namhoc
                    }
                };
                var response = db.GetList(request).Data.toList<TimetableModel>();
                return response;
            }
        } 
        public static List<TimetableModel> TT_GET_TIMETABLE(int idcanbo, int hocki, string namhoc)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_GET_TKB_CB",
                    Params = new
                    {
                        id_can_bo = idcanbo,
                        hoc_ki = hocki,
                        nam_hoc = namhoc
                    }
                };
                var response = db.GetList(request).Data.toList<TimetableModel>();
                return response;
            }
        }
        public static List<TimetableModel> TT_GET_TIMETABLE_PH(int idphonghoc, int hocki, string namhoc)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_GET_TKB_PH",
                    Params = new
                    {
                        id_phong_hoc = idphonghoc,
                        hoc_ki = hocki,
                        nam_hoc = namhoc
                    }
                };
                var response = db.GetList(request).Data.toList<TimetableModel>();
                return response;
            }
        }
        public static List<TimetableModel> TT_GET_TIMETABLE(int idtkb)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_GET_INFO_TKB_CB",
                    Params = new
                    {
                        id_tkb = idtkb
                    }
                };
                var response = db.GetList(request).Data.toList<TimetableModel>();
                return response;
            }
        }
        #endregion
        #region lay thong tin thoi khoa bieu theo ma nhom hoc phan, thu, tiet
        public static TimetableModel TT_GET_TIMETABLE(int manhomhp, int tiet, int thu)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_GET_INFO_TKB",
                    Params = new
                    {
                        ma_nhom_hp = manhomhp,
                        tiet = tiet,
                        thu = thu
                    }
                };
                var response = db.GetList(request).Data.toList<TimetableModel>().FirstOrDefault();
                return response;
            }
        }
        #endregion

        #region insert thoi khoa bieu
        public static Response TT_INSERT_TIMETABLE(TimetableData tb)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_Insert_Timetable",
                    Params = new
                    {
                        ma_nhom_hp = tb.MaNhomHp,
                        id_tiet = tb.IdTiet,
                        id_thu = tb.IdThu,
                        id_can_bo = tb.IdCanBo,
                        id_phong_hoc = tb.IdPhongHoc,
                        id_hoc_ki = tb.IdHocKi,
                        so_tiet = tb.SoTiet,
                        vi_pham = tb.ViPham
                    }
                };
                var response = db.Execute(request);
                return response;
            }
        }
        #endregion
         #region updatee thoi khoa bieu
        public static Response TT_UPDATE_TIMETABLE(TimetableData tb)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_UPDATE_Timetable",
                    Params = new
                    {
                        ID_THOI_KHOA_BIEU = tb.IdTimetable,
                        ma_nhom_hp = tb.MaNhomHp,
                        id_tiet = tb.IdTiet,
                        id_thu = tb.IdThu,
                        id_can_bo = tb.IdCanBo,
                        id_phong_hoc = tb.IdPhongHoc,
                        id_hoc_ki = tb.IdHocKi,
                        so_tiet = tb.SoTiet,
                        vi_pham = tb.ViPham
                    }
                };
                var response = db.Execute(request);
                return response;
            }
        }
        #endregion

        #region delete thoi khoa bieu
        public static Response TT_DELETE_ALL_TIMETABLE(int hocki, string namhoc)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_DELETE_ALL_Timetable",
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
        #region delete thoi khoa bieu
        public static Response TT_DELETE_TIMETABLE(int manhomHP)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                   Query = "Delete from tt_thoi_khoa_bieu where ma_nhom_hoc_phan = " + manhomHP
                };
                var response = db.Execute(request);
                return response;
            }
        }
        #endregion
    }
}
