using Core.Common;
using Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.SERVER.Database;
using Timetable.SERVER.Models;

namespace Timetable.SERVER.Repositories
{
    public class HocPhanRepository
    {
        #region lay danh sach hoc phan
        public static List<HocPhanModel> TT_DS_HOCPHAN()
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "select *  from tt_hoc_phan"
                };
                var response = db.GetList(request).Data.toList<HocPhanModel>();
                return response;
            }
        }
        #endregion

        #region trả về dữ liệu học phần theo mã học phần
        public static HocPhanModel TT_HOCPHAN(string mahp)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_HOCPHAN_DATA",
                    Params = new
                    {
                        ma_hp = mahp
                    }

                };
                var response = db.GetList(request).Data.toList<HocPhanModel>().FirstOrDefault();
                return response;
            }
        }
        #endregion
        #region trả về dữ liệu học phần theo id nhóm học phần
       
        #endregion
        #region kế hoạch học tập
        #region Trả về số lượng học phần được đăng kí trong học kì
        public static List<KHHTModel> TT_SUM_KHHT(int hoc_ki, string nam_hoc)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_SUM_KHHT",
                    Params = new
                    {
                        hoc_ki = hoc_ki,
                        nam_hoc = nam_hoc
                    }
                };
                var response = db.GetList(request).Data.toList<KHHTModel>();
                return response;
            }
        }
        #endregion
        #region Trả về kế hoạch hoc tập toàn khóa của sinh viên
        public static List<KHHTModel> TT_GET_KHHT_SV(string MSSV)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_GET_KHHT_SV",
                    Params = new
                    {
                        masinhvien = MSSV
                    }
                };
                var response = db.GetList(request).Data.toList<KHHTModel>();
                return response;
            }
        }
        #endregion
        #region Thông tin kế hoạch hoc tập 
        public static List<KHHTSinhVienModel> TT_GET_KHHT(int id)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "Select * from tt_khht where id_khht = " + id
                };
                var response = db.GetList(request).Data.toList<KHHTSinhVienModel>();
                return response;
            }
        }
        #endregion

        #region Trả về kế hoạch hoc tập trong học kì của sinh viên
        public static List<KHHTModel> TT_GET_KHHT_SV(string MSSV, int hocki, string namhoc)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_GET_KHHT_SV_HK",
                    Params = new
                    {
                        masinhvien = MSSV,
                        hocki = hocki,
                        namhoc = namhoc
                    }
                };
                var response = db.GetList(request).Data.toList<KHHTModel>();
                return response;
            }
        }
        #endregion
        #region Tìm kiếm khht theo học phần của sinh viên
        public static List<KHHTModel> TT_SEARCH_KHHT(string MSSV, string mahocphan)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_SEARCH_KHHT",
                    Params = new
                    {
                        masinhvien = MSSV,
                        mahocphan = mahocphan
                    }
                };
                var response = db.GetList(request).Data.toList<KHHTModel>();
                return response;
            }
        }
        #endregion
        #region Thêm khht theo học phần của sinh viên
        public static Response TT_INSERT_KHHT(string MSSV, string mahocphan, int idhocki, int caithien)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_INSERT_KHHT",
                    Params = new
                    {
                        masinhvien = MSSV,
                        mahocphan = mahocphan,
                        hocki = idhocki,
                        caithien = caithien
                    }
                };
                var response = db.Execute(request);
                return response;
            }
        }
        #endregion
        #region Update khht theo học phần của sinh viên
        public static Response TT_UPDATE_KHHT(string MSSV, string mahocphan, int idhocki, int caithien)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_UPDATE_KHHT",
                    Params = new
                    {
                        masinhvien = MSSV,
                        mahocphan = mahocphan,
                        hocki = idhocki,
                        caithien = caithien
                    }
                };
                var response = db.Execute(request);
                return response;
            }
        }
        #endregion
        #region dêlete khht theo học phần của sinh viên
        public static Response TT_DELETE_KHHT(int idkhht)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_DELETE_KHHT",
                    Params = new
                    {
                        id_khht = idkhht
                    }
                };
                var response = db.Execute(request);
                return response;
            }
        }
        #endregion

        #endregion
    }
}
