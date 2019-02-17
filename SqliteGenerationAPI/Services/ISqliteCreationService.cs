using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using SqliteGeneration.Core;

namespace SqliteGenerationAPI.Services
{
    public interface ISqliteCreationService
    {
        Stream CreateSqliteTableAndPopulateDb(Tuple<List<PropertyInfo>, List<TodoItem>> propertiesAndData);
    }
}
