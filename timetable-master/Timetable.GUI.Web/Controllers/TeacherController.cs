using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Timetable.GUI.Forms.Service;
using Timetable.GUI.Web.Session;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Web.Controllers
{
    public class TeacherController : Controller
    {
        public bool CheckPermission()
        {
            if (HttpContext.Session.GetString(UserSession.SessionKeyName) == null || Users.PERMISSION.Equals("Sinh viên"))
                return true;
            return false;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ThoiKhoaBieu()
        {
            if (CheckPermission())
                return RedirectToAction("Login", "User");
            return View();
        }
        [HttpGet]
        public IActionResult ThoiKhoaBieu(int hocki, string namhoc)
        {
            if (CheckPermission())
                return RedirectToAction("Login", "User");

            if (hocki == 0 && namhoc == null)
                return View();
            else
            {
                var idcanbo = int.Parse(Users.ID);
                var tkb = TimetableService.timetables(idcanbo, hocki, namhoc).Tkb.OrderBy(x => x.IdThu);
                ViewData["hocki"] = hocki;
                ViewData["namhoc"] = namhoc;
                HttpContext.Session.SetInt32("hocki", hocki);
                HttpContext.Session.SetString("namhoc", namhoc);
                return View(tkb);
            }
        }

        [HttpGet]
        public IActionResult UpdateTimetable(int idtimetable)
        {
            var hocki = HttpContext.Session.GetInt32("hocki");
            var namhoc = HttpContext.Session.GetString("namhoc");
            ViewData["hocki"] = hocki;
            ViewData["namhoc"] = namhoc;
            var item = TimetableService.getTimtableInfo(idtimetable);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateTimetable(int idtimetable, int thu, int tiet, int idroom)
        {
            try
            {
                var tkb = TimetableService.getTimtableInfo(idtimetable);
                var hocki = HttpContext.Session.GetInt32("hocki");
                var namhoc = HttpContext.Session.GetString("namhoc");
                ViewData["hocki"] = hocki;
                ViewData["namhoc"] = namhoc;

                var idcanbo = int.Parse(Users.ID);
                var timetables = TimetableService.timetables(idcanbo, (int)hocki, namhoc).Tkb.Where(x=>x.IdThu==thu);

                int lastTiet = tiet + tkb.SoTiet - 1;
                bool flagTiet = true, flagRoom = true;
                if (lastTiet > 9 || (tiet < 6 && lastTiet > 6))
                    flagTiet = false;
                else flagTiet = checkError(timetables, tkb, tiet);
                
                var timetableOfRoom = TimetableService.timetables_room(idroom, (int)hocki, namhoc).Tkb.Where(x => x.IdThu == thu);
                if (timetableOfRoom != null)
                    flagRoom = checkError(timetableOfRoom, tkb, tiet);
                if (!flagRoom)
                    ModelState.AddModelError("", "Phòng học này đã được sắp lịch ở tiết này. Vui lòng chọn tiết khác hoặc phòng khác!!");

                else if (!flagTiet)
                    ModelState.AddModelError("", "Tiết đã chọn trùng lịch giảng dạy. Vui lòng chọn tiết khác!!");
                else
                {
                    tkb.IdThu = thu;
                    tkb.IdTiet = tiet;
                    //tkb.IdPhongHoc = idroom;
                    TimetableService.UpdateTimetable(tkb);

                    return RedirectToAction("ThoiKhoaBieu", "Teacher", new { hocki = hocki, namhoc = namhoc });
                }    
                return View(tkb);
            }
            catch (Exception)
            {
                return View();
            }
        }

        bool checkError(IEnumerable<TimetableData> timetables, TimetableData tkb, int tiet)
        {
            foreach (var item in timetables)
            {
                for (int i = 0; i < item.SoTiet; i++)
                {
                    int tiet_ = item.IdTiet + i;
                    if (tiet == tiet_)
                        return false;
                }
                for (int i = 0; i < tkb.SoTiet; i++)
                {
                    int tiet_ = tiet + i;
                    if (item.IdTiet == tiet_)
                        return false;
                }
            }
            return true;
        }
    }
}
