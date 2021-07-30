using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Timetable.GUI.Forms.Service;
using Timetable.GUI.Web.Service;
using Timetable.GUI.Web.Session;

namespace Timetable.GUI.Web.Controllers
{
    public class HocPhanController : Controller
    {
        public bool CheckPermission()
        {
            if (HttpContext.Session.GetString(UserSession.SessionKeyName) == null)
                return true;
            return false;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DMThoiKhoaBieu()
        {
            if (CheckPermission())
                return RedirectToAction("Login", "User");
            return View();
        }
        [HttpGet]
        public IActionResult DMThoiKhoaBieu(int hocki, string namhoc)
        {
            if (CheckPermission())
                return RedirectToAction("Login", "User");
            if (hocki == 0 && namhoc == null)
                return View();
            else
            {
                var listTKB = TimetableService.timetables(hocki, namhoc);
                ViewData["hocki"] = hocki;
                ViewData["namhoc"] = namhoc;
                HttpContext.Session.SetInt32("hocki", hocki);
                HttpContext.Session.SetString("namhoc", namhoc);
                return View(listTKB);
            }
        }


    }
}
