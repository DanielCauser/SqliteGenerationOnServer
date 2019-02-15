using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SqliteGenerationAPI.Datas;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SqliteGenerationAPI.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        private readonly DataContext _dbContext;

        public DataController(DataContext dbContext)
        {
            _dbContext = dbContext;
            if (_dbContext.TodoItems.Count() == 0)
            {
                // Seed
                var list = new List<TodoItem>();

                using (var reader = new StreamReader(Assembly.GetAssembly(typeof(Startup))
                                                               .GetManifestResourceStream(Assembly.GetAssembly(typeof(Startup)).GetManifestResourceNames().First()) ?? throw new InvalidOperationException()))
                {
                    list = JsonConvert.DeserializeObject<List<TodoItem>>(reader.ReadToEnd());
                }

                _dbContext.TodoItems.AddRange(list);
                _dbContext.SaveChanges();
            }
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            return await _dbContext.TodoItems.ToListAsync();
        }

        [HttpGet("GenerateSqlite")]
        public string GenerateSqlite()
        {
            return "value";
        }
    }
}
