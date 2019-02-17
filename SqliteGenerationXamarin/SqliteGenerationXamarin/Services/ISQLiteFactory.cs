using System;
using System.Threading.Tasks;

namespace SqliteGenerationXamarin.Services
{
    public interface ISQLiteFactory
    {
        Task DownloadSqlite(Action<string> messageUpdateAction);
        void DeleteSqliteFile();
    }
}