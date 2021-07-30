using Core.Common;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core.Database
{
    public class Response
    {
        public DataTable Data { get; set; } = new DataTable();
        public SqlParameterCollection Params { get; set; }
        public SqlParameterCollection _Params { get; set; }
        public int resultExecute { set; get; }

        public string GetStringParam(string name)
        {
            name = "P_" + name.ToUpper();
            return Params[name].Value.toString();
        }

        public Int32 GetInt32Param(string name)
        {
            name = "P_" + name.ToUpper();
            return Params[name].Value.toInt();
        }

        public Int32 _GetInt32Param(string name)
        {
            name = "P_" + name.ToUpper();
            return _Params[name].Value.toInt();
        }

        public string _GetStringParam(string name)
        {
            name = "P_" + name.ToUpper();
            return _Params[name].Value.toString();
        }
    }
}
