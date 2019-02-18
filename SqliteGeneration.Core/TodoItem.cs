using System;
using SQLite;

namespace SqliteGeneration.Core
{
    public class TodoItem
    {
        [PrimaryKey]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}