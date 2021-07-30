using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using Timetable.SERVER.Protos;

namespace Timetable.GUI.Forms.Model
{
    public  class DangNhap
    {
        public static CanBoData cb { set; get; }
        public static DateTime TimeLogin { set; get; } = DateTime.Now;

    }
}
