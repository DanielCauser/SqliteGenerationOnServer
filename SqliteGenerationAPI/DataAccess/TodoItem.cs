using System;
using SQLite;

namespace SqliteGenerationAPI.Datas
{
    public class TodoItem
    {
        [PrimaryKey]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}