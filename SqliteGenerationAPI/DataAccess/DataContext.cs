using Microsoft.EntityFrameworkCore;
using SqliteGeneration.Core;

namespace SqliteGenerationAPI.DataAccess
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
