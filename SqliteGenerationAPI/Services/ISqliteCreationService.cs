using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using SqliteGenerationAPI.Datas;

namespace SqliteGenerationAPI.Services
{
    public interface ISqliteCreationService
    {
        Stream CreateSqliteTableAndPopulateDb(Tuple<List<PropertyInfo>, List<TodoItem>> propertiesAndData);
    }
}
