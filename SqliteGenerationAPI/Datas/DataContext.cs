using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace SqliteGenerationAPI.Datas
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed
            var list = new List<TodoItem>();

            using (var reader = new StreamReader(Assembly.GetAssembly(typeof(Startup))
                                                     .GetManifestResourceStream(Assembly.GetAssembly(typeof(Startup)).GetManifestResourceNames().First()) ?? throw new InvalidOperationException()))
            {
                list = JsonConvert.DeserializeObject<List<TodoItem>>(reader.ReadToEnd());
            }

            modelBuilder.Entity<TodoItem>().HasData(list.ToArray());
        }
    }
}
