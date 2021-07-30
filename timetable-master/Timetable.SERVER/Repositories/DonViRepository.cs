using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.SERVER.Database;
using Timetable.SERVER.Models;

namespace Timetable.SERVER.Repositories
{
    public class DonViRepository
    {
        #region lay danh sach tat ca don vi
        public static List<DonViModel> TT_DS_DONVI()
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_don_vi"
                };
                var response = db.GetList(request).Data.toList<DonViModel>();
                return response;
            }
        }
        #endregion 
        #region lay danh sach don vi theo loai don vi
        public static List<DonViModel> TT_DS_DONVI(int id)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_don_vi where id_loai_don_vi = " + id
                };
                var response = db.GetList(request).Data.toList<DonViModel>();
                return response;
            }
        }
        #endregion
        #region lay danh sach don vi con theo ma don vi cha
        public static List<DonViModel> TT_DS_DONVI_CON(int id)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_don_vi where ma_don_vi_cha = " + id
                };
                var response = db.GetList(request).Data.toList<DonViModel>();
                return response;
            }
        }
        #endregion
        #region lay thong tin don vi theo ma don vi
        public static DonViModel TT_DON_VI_INFO(int id)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_don_vi where ma_don_vi = " + id
                };
                var response = db.GetList(request).Data.toList<DonViModel>();
                return response.FirstOrDefault();
            }
        }
        #endregion
    }
}
