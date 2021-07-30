using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.SERVER.Database;
using Timetable.SERVER.Models;

namespace Timetable.SERVER.Repositories
{
    public class CongTacRepostory
    {
        #region lay danh sach tat ca don vi
        public static List<CongTacModel> TT_DS_CONGTAC(int idCB)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_GET_CONG_TAC",
                    Params = new { idcanbo = idCB }
                };
                var response = db.GetList(request).Data.toList<CongTacModel>();
                return response;
            }
        }
        #endregion 
    }

    public class ChucVuRepository
    {
        #region lay danh sach tat ca don vi
        public static List<ChucVuModel> TT_DS_CHUCVU()
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_chuc_vu"
                };
                var response = db.GetList(request).Data.toList<ChucVuModel>();
                return response;
            }
        }

        //Thong tin 1 chuc vu
        public static ChucVuModel TT_CHUCVU_INFO(int macv)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_chuc_vu where ma_chuc_vu = " + macv
                };
                var response = db.GetList(request).Data.toList<ChucVuModel>();
                return response.FirstOrDefault();
            }
        }
        #endregion 
    }
}
