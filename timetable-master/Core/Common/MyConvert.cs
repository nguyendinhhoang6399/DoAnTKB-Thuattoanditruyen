using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Common
{
    public static class MyConvert
    {
        //public static JToken toJson(this DataTable dt)
        //{
        //    return JsonHelper.ToJson(dt);
        //}

        public static string toString(this object value)
        {
            return value.ToString();
        }

        public static Int32 toInt(this object value)
        {
            return Int32.Parse(value.ToString());
        }

        //public static Int32 toAppId(this string app_token)
        //{
        //    var app_id = Convert.ToInt32(app_token.Decrypt());
        //    return app_id;
        //}
    }
}
