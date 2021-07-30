using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Timetable.GUI.Web.Service;
using Timetable.GUI.Web.Session;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Web.Controllers
{
    public class StudentController : Controller
    {
        public bool CheckPermission()
        {
            if (HttpContext.Session.GetString(UserSession.SessionKeyName) == null || !Users.PERMISSION.Equals("Sinh viên"))
                return true;
            return false;
        }
        public IActionResult khht_of_course()
        {
            if (CheckPermission())
                return RedirectToAction("Login", "User");
            var mssv = HttpContext.Session.GetString(UserSession.SessionKeyID);
            var listKHHT = KHHTService.GetAllKHHTSV(mssv);
            return View(listKHHT);
        }
        public IActionResult khht()
        {
            if (CheckPermission())
                return RedirectToAction("Login", "User");
            return View();
        }
        [HttpGet]
        public IActionResult khht(int hocki, string namhoc)
        {
            if (CheckPermission())
                return RedirectToAction("Login", "User");
            var mssv = HttpContext.Session.GetString(UserSession.SessionKeyID);
            if (hocki == 0 && namhoc == null)
                return View();
            else
            {
                var listKHHT = KHHTService.GetKHHTSV(mssv, hocki, namhoc);
                ViewData["hocki"] = hocki;
                ViewData["namhoc"] = namhoc;
                HttpContext.Session.SetInt32("hocki", hocki);
                HttpContext.Session.SetString("namhoc", namhoc);
                return View(listKHHT);
            }
        }
        [HttpPost]
        public IActionResult DeleteKHHT(int id)
        {
            int hk = 1;
            string nh = "2020 - 2021";
            try
            {
                KHHTService.DeleteKHHT(id);
                hk = HttpContext.Session.GetInt32("hocki").Value;
                nh = HttpContext.Session.GetString("namhoc");
            }
            catch (Exception e) { ModelState.AddModelError("", "Error save data"); }
            return RedirectToAction("khht", "Student", new { hocki = hk, namhoc = nh });
        }
        [HttpPost]
        public IActionResult UpdateKHHT(int id, IFormCollection form)
        {
            int hk = 1;
            string nh = "2020 - 2021";
            try
            {
                KHHT_SinhVien kh = KHHTService.FindKHHT(id);

                hk = int.Parse(form["u_hocki"].ToString());
                nh = form["u_namhoc"];

                int idhk = TimeslotService.getHocKi(hk, nh).IdHocKi;


                kh.Hocki = idhk;
                KHHTService.UpdateKHHT(kh);

                hk = HttpContext.Session.GetInt32("hocki").Value;
                nh = HttpContext.Session.GetString("namhoc");
            }
            catch (Exception e) { ModelState.AddModelError("", "Error save data"); }
            return RedirectToAction("khht", "Student", new { hocki = hk, namhoc = nh });
        }
        [HttpPost]
        public IActionResult AddKHHT(string mahocphan, int caithien)
        {
            int hk = 1;
            string nh = "2016 - 2017";           
            try
            {
                hk = HttpContext.Session.GetInt32("hocki").Value;
                nh = HttpContext.Session.GetString("namhoc");
                var hocki = TimeslotService.getHocKi(hk, nh).IdHocKi;
                KHHT_SinhVien kh = new KHHT_SinhVien()
                {
                    Masinhvien = HttpContext.Session.GetString(UserSession.SessionKeyID),
                    Hocki = hocki,
                    Mahocphan = mahocphan,
                    Caithien = caithien
                };
                KHHTService.InsertKHHT(kh);
            }
            catch (Exception e) { ModelState.AddModelError("", "Error save data"); }
            return RedirectToAction("khht", "Student", new { hocki = hk, namhoc = nh });
        }


    }
}
