using System;
using System.IO;
using System.Threading.Tasks;
using Plugin.HttpTransferTasks;
using ReactiveUI.Fody.Helpers;
using System.Net.Http;
using HttpTracer;
using SqliteGeneration.Core;
using System.Collections.Generic;
using SQLite;
using System.ComponentModel;

namespace SqliteGenerationXamarin.Services
{
    public class SQLiteFactory : ISQLiteFactory
    {
        private Action<string> _messageUpdateAction;
        private readonly string _databasePath;
        private readonly IHttpTransferTasks _httpTransferTask;

        private IHttpTask DownloadSqliteTask { get; set; }
        public bool DoesLocalDbExists => File.Exists(_databasePath);
        bool DownloadCompleted { get; set; }

        public SQLiteFactory(IHttpTransferTasks httpTransferTask)
        {
            _databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Todo.db");
            _httpTransferTask = httpTransferTask;
        }

        public async Task DownloadSqlite(Action<string> messageUpdateAction)
        {
            _messageUpdateAction = messageUpdateAction;
            if (!DoesLocalDbExists)
            {
                var url = await RequestSqliteGenerationAndDownloadUrl();
                DownloadSqliteFile(url);
                while (!DownloadCompleted)
                {
                    _messageUpdateAction($"Downloading db - {DownloadSqliteTask.PercentComplete}%");
                    await Task.Delay(10);
                }
            }

            DownloadCompleted = false;
        }

        private async Task<string> RequestSqliteGenerationAndDownloadUrl()
        {
            _messageUpdateAction("Generating DB on the cloud...");

            HttpResponseMessage result;
            using (HttpClient client = new HttpClient(new HttpTracerHandler()))
            {
                //result = await client.GetAsync("http://10.211.55.3:49787/api/data/generateSqlite");
                result = await client.GetAsync("https://causerdemomassive.azurewebsites.net/api/data/generateSqlite");
            }

            if (result.IsSuccessStatusCode)
                return await result.Content.ReadAsStringAsync();

            throw new Exception("Could not Generate sqlite on the cloud.");
        }

        private void DownloadSqliteFile(string downloadUrl)
        {
            DownloadSqliteTask = _httpTransferTask.Download(downloadUrl.Replace("\"", ""));
            DownloadSqliteTask.PropertyChanged -= Handler;
            DownloadSqliteTask.PropertyChanged += Handler;
        }

        private void Handler(object sender, PropertyChangedEventArgs e)
        {
            if (DownloadSqliteTask.Status == Plugin.HttpTransferTasks.TaskStatus.Completed)
            {
                File.Move(DownloadSqliteTask.LocalFilePath, _databasePath);
                File.Delete(DownloadSqliteTask.LocalFilePath);
                DownloadCompleted = true;
            }
        }

        public void DeleteSqliteFile()
        {
            File.Delete(_databasePath);
        }

        public async Task<List<TodoItem>> FetchTodoData()
        {
            if(DoesLocalDbExists)
            {
                var db = new SQLiteAsyncConnection(_databasePath, true);
                var result = await db.QueryAsync<TodoItem>("select * from TodoItem");
                return result;
            }
            return new List<TodoItem>();
        }
    }
}
