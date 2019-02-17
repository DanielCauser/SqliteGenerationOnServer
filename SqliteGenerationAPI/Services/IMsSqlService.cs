using System;
using System.Collections.Generic;
using System.Reflection;
using SqliteGeneration.Core;

namespace SqliteGenerationAPI.Services
{
    public interface IMsSqlService
    {
        Tuple<List<PropertyInfo>, List<TodoItem>>  QueryDataFromMsSql();
    }
}
