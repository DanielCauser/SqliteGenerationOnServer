using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SqliteGeneration.Core;

namespace SqliteGenerationXamarin.Services
{
    public interface ISQLiteFactory
    {
        bool DoesLocalDbExists { get; }
        Task DownloadSqlite(Action<string> messageUpdateAction);
        void DeleteSqliteFile();
        Task<List<TodoItem>> FetchTodoData();
    }
}