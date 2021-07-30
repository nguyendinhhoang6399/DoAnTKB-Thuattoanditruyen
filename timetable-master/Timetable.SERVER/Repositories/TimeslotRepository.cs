using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.SERVER.Database;
using Timetable.SERVER.Models;

namespace Timetable.SERVER.Repositories
{
    public class TimeslotRepository
    {
        #region lay danh sach tiet hoc
        public static List<Tiet> TT_DS_TIET_HOC()
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_tiet_hoc"
                };
                var response = db.GetList(request).Data.toList<Tiet>();
                return response;
            }
        }
        #endregion

        #region lay danh sach thu
        public static List<Thu> TT_DS_THU()
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_thu"
                };
                var response = db.GetList(request).Data.toList<Thu>();
                return response;
            }
        }
        #endregion

        #region lay danh sach lich ban của can bo
        public static List<TimeBusyProf> TT_TimeBusyProf()
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_lich_ban_can_bo"
                };
                var response = db.GetList(request).Data.toList<TimeBusyProf>();
                return response;
            }
        }
        public static List<TimeBusyProf> TT_TimeBusyProf(int idcanbo)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_lich_ban_can_bo where id_can_bo = " + idcanbo
                };
                var response = db.GetList(request).Data.toList<TimeBusyProf>();
                return response;
            }
        }
        #endregion

        #region lay danh sach lich ban của phong hoc
        public static List<TimeBusyRoom> TT_TimeBusyRoom()
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_lich_ban_phong_hoc"
                };
                var response = db.GetList(request).Data.toList<TimeBusyRoom>();
                return response;
            }
        }
        #endregion

        #region lay thong tin hoc ki
        public static List<HocKiModel> TT_HocKi(int hocki, string namhoc)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_hoc_ki where hoc_ki = " + hocki + " and nam_hoc = '" + namhoc + "'"
                };
                var response = db.GetList(request).Data.toList<HocKiModel>();
                return response;
            }
        } 
        public static List<HocKiModel> TT_HocKiByID(int idhk)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_hoc_ki where id_hoc_ki = " + idhk
                };
                var response = db.GetList(request).Data.toList<HocKiModel>();
                return response;
            }
        }
        #endregion
    }
}
