using Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timetable.SERVER.Database
{
    public class DbContext : Dbutils
    {
        private const string datasource = @"DESKTOP-PBM2SJ4\SQLEXPRESS";
        private const string database = "TimeTable";
        private const string username = "sa";
        private const string password = "123";
        private const string ConnectString = "Data Source = " + datasource + "; Initial Catalog = "
                           + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;



        public DbContext() : base(ConnectString)
        {
        }
    }
}
