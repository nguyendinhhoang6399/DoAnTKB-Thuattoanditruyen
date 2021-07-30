using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.SERVER.Database;
using Timetable.SERVER.Models;

namespace Timetable.SERVER.Repositories
{
    public class CanBoRepository
    {
        #region lay danh sach can bo
        public static List<CanboModel> TT_DS_CANBO()
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_can_bo"
                };
                var response = db.GetList(request).Data.toList<CanboModel>();
                return response;
            }
        }
        #endregion

        #region lấy dánh sách cán bộ theo đơn vị
        public static List<CanboModel> TT_FIND_CANBO_DV(int madv)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_FIND_CANBO_DV",
                    Params = new
                    {
                        ma_don_vi = madv
                    }
                };
                var response = db.GetList(request).Data.toList<CanboModel>();
                return response;
            }
        }
        #endregion
        #region Đăng nhập 
        public static CanboModel TT_LOGIN(string username, string password)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    //StoreName = "TT_LOGIN_CANBO",
                    //Params = new
                    //{
                    //    username = username,
                    //    password = password
                    //}
                    Query = "select * from tt_can_bo where username='"+username+"' and password='"+password+"'"
                };
                var response = db.GetList(request).Data.toList<CanboModel>().FirstOrDefault();
               
               
                return response;
            }
        }
        #endregion
        public static List<CanboModel> TT_FINDCANBO(int macanbo)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_FIND_CANBO",
                    Params = new
                    {
                        idcanbo = macanbo
                    }
                };
                var response = db.GetList(request).Data.toList<CanboModel>();
                return response;
            }
        }

        #region Danh sách tôn giáo, dân tộc
        public static List<TonGiaoModel> TT_DS_TONGIAO()
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_ton_giao"
                };
                var response = db.GetList(request).Data.toList<TonGiaoModel>();
                return response;
            }
        }

        public static TonGiaoModel TT_TONGIAO(int matongiao)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_ton_giao where ma_ton_giao = " + matongiao
                };
                var response = db.GetList(request).Data.toList<TonGiaoModel>().FirstOrDefault();
                return response;
            }
        }

        public static List<DanTocModel> TT_DS_DANTOC()
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_dan_toc"
                };
                var response = db.GetList(request).Data.toList<DanTocModel>();
                return response;
            }
        }
        public static DanTocModel TT_DANTOC(int madantoc)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_dan_toc where ma_dan_toc = " + madantoc
                };
                var response = db.GetList(request).Data.toList<DanTocModel>().FirstOrDefault();
                return response;
            }
        }


        #endregion
    }
}
