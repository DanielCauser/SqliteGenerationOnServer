using System;
using Microsoft.EntityFrameworkCore;

namespace SqliteGenerationAPI.Datas
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
