using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Timetable.GUI.Web.Service;
using Timetable.GUI.Web.Models;
using Timetable.SERVER.Protos;
using Timetable.GUI.Web.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace Timetable.GUI.Web.Controllers
{
    public class UserController : Controller
    {

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View();
            else
            {
                if (model.IsCanBo(model))
                {
                    HttpContext.Session.SetString(UserSession.SessionKeyName, model.Username);
                    return RedirectToAction("Index", "Teacher");
                }
                else if (model.IsSinhVien(model))
                {
                    HttpContext.Session.SetString(UserSession.SessionKeyName, model.Username);
                    HttpContext.Session.SetString(UserSession.SessionKeyID, model.Username);
                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng!");
                return View(model);

            }
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login","User");
        }



    }


}
