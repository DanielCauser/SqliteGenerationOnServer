using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public readonly IMsSqlService _msSqlService;
        private readonly ISqliteCreationService _sqliteCreationService;
        private readonly IBlobStorageService _storageService;

        public DataController(DataContext dbContext, 
            IMsSqlService msSqlService,
            ISqliteCreationService sqliteCreationService,
            IBlobStorageService storageService)
        {
            _dbContext = dbContext;
            _msSqlService = msSqlService;
            _sqliteCreationService = sqliteCreationService;
            _storageService = storageService;
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            return await _dbContext.TodoItems.ToListAsync();
        }

        [HttpGet("GenerateSqlite")]
        public async Task<ActionResult<string>> GenerateSqlite()
        {
            // 1 - Fetch Data from MsSql
            // 2 - Define columns(Class properties) that will be created in Sqlite
            var propertiesAndData = _msSqlService.QueryDataFromMsSql();

            // 3 - Create Sqlite File
            // 4 - Create Tables
            // 5 - Insert Data
            var sqliteFile = _sqliteCreationService.CreateSqliteTableAndPopulateDb(propertiesAndData);

            // 6 - Upload file to BlobStorage
            var downloadUrl = await _storageService.UploadBlobAsync("sqlitefile", "Todo.db",
                "application/octet-stream", sqliteFile);

            sqliteFile.Close();

            return downloadUrl;
        }
    }
}
