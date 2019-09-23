using System.IO;

namespace SqliteGenerationAPI.Services
{
    public interface IMsSqlToSqlite
    {
        Stream Execute();
    }
}
