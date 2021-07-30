using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.SERVER.Database;
using Timetable.SERVER.Models;

namespace Timetable.SERVER.Repositories
{
    public class Test
    {
        public static List<CanboModel> TT_FINDCANBO(string macanbo)
        {
            using (var db = new DbContext())
            {
                var request = new Core.Database.Request
                {
                    StoreName = "TT_FIND_CANBO",
                    Params = new
                    {
                        macanbo = macanbo
                    }
                };
                var response = db.GetList(request).Data.toList<CanboModel>();
                return response;
            }
        }
    }
}
