using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Timetable.GUI.Web.Session
{
    public class UserSession : Controller
    {
       
        public const string SessionKeyName = "_Name";
        public const string SessionKeyID = "_ID";
        const string SessionKeyTime = "_Time";

        public string SessionInfo_Name { get; private set; }
        public string SessionInfo_ID { get; private set; }
        public string SessionInfo_CurrentTime { get; private set; }
        public string SessionInfo_SessionTime { get; private set; }
        public string SessionInfo_MiddlewareValue { get; private set; }

        public void OnSet( string name)
        {
            HttpContext.Session.SetString(SessionInfo_ID, name);
        }
        public string getName()
        {
            SessionInfo_Name = HttpContext.Session.GetString(SessionInfo_ID);
            return SessionInfo_Name;
        }
    }
}
