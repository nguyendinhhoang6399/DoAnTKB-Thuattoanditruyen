using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Core.Database
{
    public class Request
    {
        /// <summary>
        /// Nếu truyền Query NULL, thì phải truyền StoreName
        /// </summary>
        public string StoreName { get; set; }
        public string Query { get; set; }
        public object Params { get; set; }
        public string Output { get; set; } = "";
        public string InputOutput { get; set; } = "";
        public string Skip { get; set; } = "";
        public bool Keep { get; set; } = false;
        public SqlConnection conn { get; set; }
        public void Close()
        {
            conn.Close();
        }
    }
}
