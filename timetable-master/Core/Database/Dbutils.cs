using Microsoft.Extensions.Configuration;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Core.Database
{
    public class Dbutils : IDisposable
    {
        private string ConnectString { get; set; }

        public Dbutils(string _ConnectString)
        {
            ConnectString = _ConnectString;
        }

        public void Dispose()
        {
        }

        private string AddParammeterToString(string str, object obj)
        {
            if (obj != null)
            {
                foreach (var prop in obj.GetType().GetProperties())
                {
                    var key = "{" + prop.Name + "}";
                    string value = "";
                    try
                    {
                        value = prop.GetValue(obj).ToString();
                    }
                    catch (Exception ex)
                    {

                    }

                    str = str.Replace(key, value);
                }
            }
            return str;
        }

        /// <summary>
        /// Hàm này dùng để:
        /// + Truy vấn dữ liệu (Select) khi type =1
        /// + Thao tác dữ liệu (Insert, Update, Delete) khi type = 0
        /// </summary>
        /// <param name="req"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private Response Run(Request req, int type)
        {
            using (req.conn = new SqlConnection(ConnectString))
            {
                req.conn.Open();
                var res = new Response();
                var StoreNameOrQuery = String.IsNullOrEmpty(req.Query) ?
                                       req.StoreName : AddParammeterToString(req.Query, req.Params);
                System.Console.WriteLine(req.Params);
                var cmd = new SqlCommand(StoreNameOrQuery, req.conn);
                cmd.DesignTimeVisible = true;

                try
                {
                    #region "Trường hợp sử dụng Store Procedure"
                    if (String.IsNullOrEmpty(req.Query))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        #region "Lấy về chuỗi param kiểu Output nếu có"
                        if (!String.IsNullOrEmpty(req.Output))
                        {
                            req.Output = ":" + req.Output;
                            req.Output = req.Output.Replace(":", ":P_");
                            req.Output += ":";
                            req.Output = req.Output.ToUpper();
                        }
                        #endregion

                        #region "Lấy về chuỗi param kiểu InputOutput"
                        if (!String.IsNullOrEmpty(req.InputOutput))
                        {
                            req.InputOutput = ":" + req.InputOutput;
                            req.InputOutput = req.InputOutput.Replace(":", ":P_");
                            req.InputOutput += ":";
                            req.InputOutput = req.InputOutput.ToUpper();
                        }
                        #endregion

                        #region "Lấy về chuỗi param cần bỏ qua nếu có"
                        if (!String.IsNullOrEmpty(req.Skip))
                        {
                            req.Skip = ":" + req.Skip;
                            req.Skip = req.Skip.Replace(":", ":P_");
                            req.Skip += ":";
                            req.Skip = req.Skip.ToUpper();
                        }
                        #endregion

                        #region "Bắt đầu truyền dữ liệu vào Store Procedure"
                        //if (type == 1)
                        //    cmd.Parameters.Add("RS", SqlDbType., ParameterDirection.Output);
                        foreach (var prop in req.Params.GetType().GetProperties())
                        {
                            var original_key = prop.Name.ToUpper();
                            var key = "P_" + original_key;
                            var value = prop.GetValue(req.Params);
                            var check_key = ":" + key + ":";

                            #region "Nếu param truyền vào không nằm trong chuỗi chỉ định bỏ qua"
                            if (req.Skip.IndexOf(check_key) == -1)
                            {
                                #region "Trường hợp param kiểu Output"
                                if (req.Output.IndexOf(check_key) != -1)
                                {
                                    if (prop.PropertyType == typeof(string))
                                    {
                                        cmd.Parameters.Add(new SqlParameter()
                                        {
                                            SqlDbType = SqlDbType.NVarChar,
                                            Direction = ParameterDirection.Output,
                                            ParameterName = key,
                                            Size = 4000
                                        });
                                        //cmd.Parameters.Add(key, SqlDbType.NVarChar, ParameterDirection.Output);
                                        //cmd.Parameters[key].Size = 4000;
                                    }
                                    else
                                    {
                                        cmd.Parameters.Add(new SqlParameter()
                                        {
                                            SqlDbType = SqlDbType.NVarChar,
                                            Direction = ParameterDirection.InputOutput,
                                            ParameterName = key
                                        });
                                        //cmd.Parameters.Add(key, SqlDbType.Int, ParameterDirection.Output);
                                    }
                                }
                                #endregion

                                #region "Trường hợp param kiểu InputOutput"
                                else if (req.InputOutput.IndexOf(check_key) != -1)
                                {
                                    if (prop.PropertyType == typeof(string))
                                    {
                                        cmd.Parameters.Add(new SqlParameter()
                                        {
                                            SqlDbType = SqlDbType.NVarChar,
                                            Direction = ParameterDirection.InputOutput,
                                            ParameterName = key,
                                            Value = value,
                                            Size = 4000
                                        });
                                        //cmd.Parameters.Add(key, SqlDbType.NVarChar).Value = value;
                                        //cmd.Parameters[key].Size = 4000;
                                    }
                                    else
                                    {
                                        cmd.Parameters.Add(new SqlParameter()
                                        {
                                            SqlDbType = SqlDbType.Int,
                                            Direction = ParameterDirection.InputOutput,
                                            ParameterName = key,
                                            Value = value
                                        });
                                        // cmd.Parameters.Add(key, SqlDbType.Int, ParameterDirection.InputOutput).Value = value;
                                    }
                                }
                                #endregion

                                #region "Trường hợp param kiểu Input"
                                else
                                {
                                    if (prop.PropertyType == typeof(string))
                                    {
                                        cmd.Parameters.Add(new SqlParameter()
                                        {
                                            SqlDbType = SqlDbType.NVarChar,
                                            Direction = ParameterDirection.Input,
                                            ParameterName = key,
                                            Value = value,
                                            Size = 4000
                                        });
                                        //cmd.Parameters.Add(key, SqlDbType.NVarChar, ParameterDirection.Input).Value = value;
                                    }
                                    else
                                    {
                                        cmd.Parameters.Add(new SqlParameter()
                                        {
                                            SqlDbType = SqlDbType.Int,
                                            Direction = ParameterDirection.Input,
                                            ParameterName = key,
                                            Value = value
                                        });
                                        //cmd.Parameters.Add(key, SqlDbType.Int, ParameterDirection.Input).Value = value;
                                    }
                                }
                                #endregion
                            }
                            #endregion
                        }
                        #endregion
                    }
                    #endregion

                    #region "Trường hợp sử dụng Text Query"
                    else
                    {
                        cmd.CommandType = CommandType.Text;
                    }
                    #endregion

                    #region "Trường hợp truy vấn dữ liệu"
                    if (type == 1)
                    {
                        var da = cmd.ExecuteReader();
                        res.Data.Load(da);
                    }
                    #endregion

                    #region "Trường hợp thao tác dữ liệu: insert, update, delete"
                    else
                    {
                        res.resultExecute = cmd.ExecuteNonQuery();
                    }
                    #endregion
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    if (!req.Keep)
                        req.conn.Close();
                }
                res._Params = cmd.Parameters;
                return res;
            }
        }

        public Response GetList(Request req)
        {
            
            var res = new Response();
            try
            {
                res = Run(req, 1);
            }
            catch (Exception ex) { }
            return res;
        }

        public Response Execute(Request req)
        {
            var res = new Response();
            try
            {
                res = Run(req, 0);
            }
            catch (Exception ex) { }

            return res;
        }
    }
}
