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
    public class SinhVienRepository
    {
        #region Đăng nhập 
        public static SinhVienData TT_LOGIN_SV(string username, string password)
        {
            System.Console.WriteLine("pass:" + password);
            System.Console.WriteLine("user:" + username);
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    //StoreName = "TT_LOGIN_SV",
                    //Params = new
                    //{
                    //    username = username,
                    //    password = password
                    //}
                    Query = "select * from tt_sinh_vien where Username='"+username+"' and password ='"+password+"'"
                };
                var response = db.GetList(request).Data.toList<SinhVienData>().FirstOrDefault();
                return response;
            }
        }
        #endregion
        public static SinhVienData TT_GET_INFO_SV(string maSV)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    Query = "Select * from tt_sinh_vien where MaSinhVien = " + maSV
                };
                var response = db.GetList(request).Data.toList<SinhVienData>();
                return response.FirstOrDefault();
            }
        }
    }
}
