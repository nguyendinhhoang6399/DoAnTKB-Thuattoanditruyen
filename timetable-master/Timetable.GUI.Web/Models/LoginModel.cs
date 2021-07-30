using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Timetable.GUI.Web.Service;
using Timetable.GUI.Web.Session;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Web.Models
{
    public class LoginModel
    {
        [Required]
        public string Username { set; get; }
        [Required]
        public string Password { set; get; }

        public bool RememberMe { set; get; }

        UserSession user = new UserSession();

        public bool IsValid(LoginModel model)
        {
            try
            {
                var cb = CanBoService.Login(model.Username, model.Password);
                if (cb != null && cb.IdCanBo > 0)
                {
                    SetUserSession(cb.IdCanBo.ToString(),cb.Tencanbo,"Cán bộ");
                    return true;
                }
            }

            catch (Exception) { }
            return false;
        } 
        public bool IsCanBo(LoginModel model)
        {
            try
            {
                var cb = CanBoService.Login(model.Username, model.Password);
                if (cb != null && cb.IdCanBo > 0)
                {
                    SetUserSession(cb.IdCanBo.ToString(),cb.Tencanbo,"Cán bộ");
                    return true;
                }
            }

            catch (Exception) { }
            return false;
        }
        public bool IsSinhVien(LoginModel model)
        {
            try
            {
                var sv = SinhVienService.LoginSV(model.Username, model.Password);
                if (sv == null || sv.MaSinhVien.Equals(""))
                    return false;
                else
                {
                    SetUserSession(sv.MaSinhVien, sv.TenSinhVien, "Sinh viên");
                    return true;
                }
            }

            catch (Exception) { }
            return false;
        }

        public void SetUserSession(string id, string name, string permission)
        {
            Users.ISLOGIN = true;
            Users.NAME = name;
            Users.ID = id;
            Users.PERMISSION = permission;
            //user.OnSet(cb.Tencanbo);
        }
    }
}
