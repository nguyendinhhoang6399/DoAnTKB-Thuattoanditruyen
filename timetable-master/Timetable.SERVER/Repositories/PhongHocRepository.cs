using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.SERVER.Database;
using Timetable.SERVER.Models;
using Timetable.SERVER.Protos;

namespace Timetable.SERVER.Repositories
{
    public class PhongHocRepository
    {
        #region lay danh sach phong hoc
        public static List<PhongHocModel> TT_DS_PHONGHOC()
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_phong_hoc"
                };
                var response = db.GetList(request).Data.toList<PhongHocModel>();
                return response;
            }
        }
        #endregion
        #region thong tin phòng học
        public static PhongHocModel TT_GET_PHONGHOC(int id)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_phong_hoc where id_phong_hoc = " + id
                };
                var response = db.GetList(request).Data.toList<PhongHocModel>().FirstOrDefault();
                return response;
            }
        }
        #endregion
        #region lay danh sach nha hoc
        public static List<NhaHocData> TT_DS_NHAHOC()
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_nha_hoc"
                };
                var response = db.GetList(request).Data.toList<NhaHocData>();
                return response;
            }
        }
        #endregion
    }
}
