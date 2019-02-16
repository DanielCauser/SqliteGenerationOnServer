using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using SqliteGenerationAPI.Datas;

namespace SqliteGenerationAPI.Services
{
    public interface IMsSqlService
    {
        Tuple<List<PropertyInfo>, List<TodoItem>>  QueryDataFromMsSql();
    }
}
