﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SqliteGenerationAPI.Datas;
using System.Linq;
using System.Data;
using System.Reflection;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace SqliteGenerationAPI.Services
{
    public class MsSqlService : IMsSqlService
    {
        private readonly DbConnection _connection;
        private IDbConnection _mssql;


        public IEnumerable<TodoItem> QueryDataFromMsSql()
        {
            List<TodoItem> list;
            _mssql = new SqlConnection("");
            _mssql.Open();
            string sql = "SELECT * FROM TodoItems ";
            var cmd = new SqlCommand(sql, (SqlConnection)_mssql);
            var reader = cmd.ExecuteReader();
            list = DataReaderMapToList<TodoItem>(reader, out var propertiesToCreateInSqlite);
            reader.Close();
            cmd.Dispose();
            return list;
        }

        private List<TodoItem> DataReaderMapToList<TodoItem>(IDataReader dr, out List<PropertyInfo> propertiesToCreateInSqlite)
        {
            List<TodoItem> list = new List<TodoItem>();
            TodoItem obj = Activator.CreateInstance<TodoItem>();
            propertiesToCreateInSqlite = new List<PropertyInfo>();
            while (dr.Read())
            {
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!ColumnExists(dr, prop.Name))
                        continue;
                    if (object.Equals(dr[prop.Name], DBNull.Value))
                        continue;
                    var valueToSet = dr[prop.Name];
                    Type targetType;
                    if (IsNullableType(prop.PropertyType))
                        targetType = Nullable.GetUnderlyingType(prop.PropertyType);
                    else
                        targetType = prop.PropertyType;
                    if (targetType.IsEnum)
                    {
                        if (valueToSet != null)
                        {
                            valueToSet = Enum.ToObject(targetType, valueToSet);
                        }
                    }
                    else
                    {
                        valueToSet = Convert.ChangeType(valueToSet, targetType);
                    }
                    prop.SetValue(obj, valueToSet, null);
                }
                list.Add(obj);
                obj = Activator.CreateInstance<TodoItem>();
            }
            propertiesToCreateInSqlite = GetMsSqlproperties();
            return list;
            List<PropertyInfo> GetMsSqlproperties()
            {
                var propList = new List<PropertyInfo>();
                try
                {
                    foreach (PropertyInfo prop in obj?.GetType()?.GetProperties())
                    {
                        if (ColumnExists(dr, prop.Name))
                            propList.Add(prop);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                return propList;
            }

            bool IsNullableType(Type type)
            {
                return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
            }

            bool ColumnExists(IDataReader reader, string columnName)
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (reader.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
