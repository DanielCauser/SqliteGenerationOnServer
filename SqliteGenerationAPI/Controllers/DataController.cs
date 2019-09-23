using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SqliteGeneration.Core;
using SqliteGenerationAPI.DataAccess;
using SqliteGenerationAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SqliteGenerationAPI.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        private readonly DataContext _dbContext;

        public readonly IMsSqlToSqlite _msSqlService;
        private readonly IBlobStorageService _storageService;

        public DataController(DataContext dbContext,
            IMsSqlToSqlite msSqlService,
            IBlobStorageService storageService)
        {
            _dbContext = dbContext;
            _msSqlService = msSqlService;
            _storageService = storageService;
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            if (!await _dbContext.TodoItems.AnyAsync())
            {
                // Seed
                var list = new List<TodoItem>();

                using (var reader = new StreamReader(Assembly.GetAssembly(typeof(Startup))
                                                         .GetManifestResourceStream(Assembly.GetAssembly(typeof(Startup)).GetManifestResourceNames().First()) ?? throw new InvalidOperationException()))
                {
                    list = JsonConvert.DeserializeObject<List<TodoItem>>(reader.ReadToEnd());
                }

                await _dbContext.TodoItems.AddRangeAsync(list);
                await _dbContext.SaveChangesAsync();
            }

            return await _dbContext.TodoItems.ToListAsync();
        }

        [HttpGet("GenerateSqlite")]
        public async Task<ActionResult<string>> GenerateSqlite()
        {
            var sqliteFile = _msSqlService.Execute();

            var downloadUrl = await _storageService.UploadBlobAsync("sqlitefile", "Todo.db",
                "application/octet-stream", sqliteFile);

            sqliteFile.Close();

            return downloadUrl;
        }
    }
}
