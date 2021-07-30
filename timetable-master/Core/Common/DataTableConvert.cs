﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.IO;

namespace Core.Common
{
    public static class DataTableConvert
    {

        // List<Student> students = Data.GetStudents();	
        // Converts List To DataTable
        // DataTable studentTbl = students.ToDataTable(); 

        public static DataTable toDataTable<T>(this IList<T> data)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in props)
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (T item in data)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        //  Converts DataTable To List
        //  DataTable dtTable = GetEmployeeDataTable();
        //  List<Employee> employeeList = dtTable.DataTableToList<Employee>();

        public static List<T> toList<T>(this DataTable table) where T : class, new()
        {
            try
            {
                List<T> list = new List<T>();

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    var row = table.Rows[i];
                    T obj = new T();

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    list.Add(obj);
                }

                return list;
            }
            catch
            {
                return null;
            }
        }
    }
}
