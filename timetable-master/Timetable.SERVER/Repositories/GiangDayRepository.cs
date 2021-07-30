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
    public class GiangDayRepository
    {
        #region lay danh sach giang day cua giang vien
        public static List<GiangDayModel> TT_DS_GIANGDAY()
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_giang_day"
                };
                var response = db.GetList(request).Data.toList<GiangDayModel>();
                return response;
            }
        }

        //Get danh sách giảng dạy theo học kì
        public static List<GiangDayModel> TT_DS_GIANGDAY(int hocki, string namhoc)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                   StoreName ="TT_GET_LIST_GIANG_DAY",
                   Params = new
                   {
                       hoc_ki = hocki,
                       nam_hoc = namhoc
                   }
                };
                var response = db.GetList(request).Data.toList<GiangDayModel>();
                return response;
            }
        }
        #endregion

        #region lay danh sach giang day theo hoc phan
        public static List<GiangDayModel> TT_DS_GIANGDAY(string mahp)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_giang_day where ma_hoc_phan = '" + mahp + "'"
                };
                var response = db.GetList(request).Data.toList<GiangDayModel>();
                return response;
            }
        }
        #endregion

        #region lay danh sach giang day theo can bo
        public static List<GiangDayModel> TT_DS_GIANGDAY(int macb)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_giang_day where id_can_bo = " + macb
                };
                var response = db.GetList(request).Data.toList<GiangDayModel>();
                return response;
            }
        }
        #endregion

        #region insert giảng dạy
        public static Response TT_INSERT_GIANGDAY(GiangDayData gd)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_INSERT_GIANG_DAY",
                    Params = new
                    {
                        macanbo = gd.IdCanBo,
                        mahocphan = gd.MaHocPhan,
                        sonhom = gd.SoNhomGiangDay,
                        hocki = gd.IdHocKi
                    }
                };
                var response = db.Execute(request);
                return response;
            }
        }
        #endregion
        #region update giảng dạy
        public static Response TT_UPDATE_GIANGDAY(GiangDayData gd)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_UPDATE_GIANG_DAY",
                    Params = new
                    {
                        macanbo = gd.IdCanBo,
                        mahocphan = gd.MaHocPhan,
                        sonhom = gd.SoNhomGiangDay,
                        hocki = gd.IdHocKi
                    }
                };
                var response = db.Execute(request);
                return response;
            }
        }
        #endregion
        #region delte all giảng dạy trong học kì
        public static Response TT_DELETE_ALL_GIANGDAY(string mahocphan, int hocki, string namhoc)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_DELETE_ALL_GIANGDAY",
                    Params = new
                    {
                        mahocphan = mahocphan,
                        hocki = hocki,
                        namhoc = namhoc
                    }
                };
                var response = db.Execute(request);
                return response;
            }
        }
        #endregion
        #region delete giảng dạy
        public static Response TT_DELETE_GIANGDAY(RequestGD req)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_DELETE_GIANGDAY",
                    Params = new
                    {
                        macanbo = req.Id,
                        mahocphan = req.Maso,
                        hocki = req.Hocki,
                        namhoc = req.Namhoc
                    }
                };
                var response = db.Execute(request);
                return response;
            }
        }
        #endregion
    }
}
