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
using SqliteGenerationAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SqliteGenerationAPI.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        private readonly DataContext _dbContext;

        public readonly IMsSqlService _msSqlService;
        private readonly ISqliteCreationService _sqliteCreationService;

        public DataController(DataContext dbContext, 
            IMsSqlService msSqlService,
            ISqliteCreationService sqliteCreationService)
        {
            _dbContext = dbContext;
            _msSqlService = msSqlService;
            _sqliteCreationService = sqliteCreationService;
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
            // 1 - Fetch Data from MsSql
            // 2 - Define columns(Class properties) that will be created in Sqlite
            var propertiesAndData = _msSqlService.QueryDataFromMsSql();

            // 3 - Create Sqlite File
            // 4 - Create Tables
            // 5 - Insert Data
            var sqliteFile = _sqliteCreationService.CreateSqliteTableAndPopulateDb(propertiesAndData);
            sqliteFile.Close();
            // 6 - Upload file to BlobStorage

            return "value";
        }
    }
}
