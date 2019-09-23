using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SQLite;
using System.IO;

namespace SqliteGenerationAPI.Services
{
    public class MsSqlToSqlite : IMsSqlToSqlite
    {
        private readonly IConfiguration _configuration;
        private IDbConnection _mssql;

        public MsSqlToSqlite(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Stream Execute()
        {
            SqlConnection sqlConnection = new SqlConnection(_configuration.GetConnectionString("TodoContext"));
            _mssql = sqlConnection;
            _mssql.Open();
            var cmd = new SqlCommand("SELECT * FROM TodoItems ", (SqlConnection)_mssql);
            var reader = cmd.ExecuteReader();

            var databasePath = Path.Combine(System.IO.Path.GetTempPath(), "TodoSqlite.db");
            File.Delete(databasePath);
            var sqlite = new SQLiteConnection(databasePath, true);


            sqlite.BeginTransaction();
            sqlite.Execute(" CREATE TABLE TodoItem ('Id' TEXT, 'Name' TEXT, PRIMARY KEY('Id'))");

            while (reader.Read())
            {
                sqlite.Execute(
                    $"INSERT INTO TodoItem (Id, Name) VALUES ('{reader.GetString(0)}', '{reader.GetString(1)}')");
            }

            sqlite.Commit();
            sqlite.Close();

            reader.Close();
            cmd.Dispose();
            return File.OpenRead(databasePath);
        }
    }
}
