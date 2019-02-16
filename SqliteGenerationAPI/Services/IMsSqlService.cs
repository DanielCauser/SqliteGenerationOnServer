using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SqliteGenerationAPI.Datas;

namespace SqliteGenerationAPI.Services
{
    public interface IMsSqlService
    {
        IEnumerable<TodoItem> QueryDataFromMsSql();
    }
}
