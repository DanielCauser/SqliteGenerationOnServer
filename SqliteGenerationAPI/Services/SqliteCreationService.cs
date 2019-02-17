using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using SQLite;
using SqliteGeneration.Core;

namespace SqliteGenerationAPI.Services
{
    public class SqliteCreationService : ISqliteCreationService
    {
        public Stream CreateSqliteTableAndPopulateDb(Tuple<List<PropertyInfo>, List<TodoItem>> propertiesAndData)
        {
            var databasePath = Path.Combine(System.IO.Path.GetTempPath(), "TodoSqlite.db");
            File.Delete(databasePath);

            var sqlite = new SQLiteConnection(databasePath, true);

            sqlite.BeginTransaction();
            sqlite.Execute(" CREATE TABLE TodoItem ('Id' TEXT, 'Name' TEXT, PRIMARY KEY('Id'))");
            foreach (var todo in propertiesAndData.Item2)
            {
                sqlite.Execute(
                    $"INSERT INTO TodoItem ({buildInsertIntoColumnNames()}) VALUES ({buildInsertIntoValues(todo)})");
            }
            sqlite.Commit();

            var r = sqlite.Query<TodoItem>("select * from TodoItem");

            sqlite.Close();

            return File.OpenRead(databasePath);
            
            string buildInsertIntoColumnNames()
            {
                StringBuilder query = new StringBuilder();
                foreach (var prop in propertiesAndData.Item1)
                {
                    if (prop == propertiesAndData.Item1.Last())
                        query.Append($"'{prop.Name}'");
                    else
                        query.Append($"'{prop.Name}',");
                }
                return query.ToString();
            }

            string buildInsertIntoValues(TodoItem obj)
            {
                StringBuilder query = new StringBuilder();
                foreach (var prop in propertiesAndData.Item1)
                {
                    if (obj.GetType().GetProperties().Any(x => x.Name == prop.Name))
                    {
                        var s = obj.GetType().GetProperty(prop.Name)?.GetValue(obj, null) is null
                            ? null
                            : obj.GetType().GetProperty(prop.Name)?.GetValue(obj, null);
                        if (prop == propertiesAndData.Item1.Last())
                            query.Append(s is null ? $"null" : $"'{s.ToString().Replace("'", "''")}'");
                        else
                            query.Append(s is null ? $"null," : $"'{s.ToString().Replace("'", "''")}',");
                    }
                }
                return query.ToString();
            }
        }
    }
}
