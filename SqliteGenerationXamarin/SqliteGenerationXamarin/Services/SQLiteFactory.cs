using System;
using System.IO;
using System.Threading.Tasks;
using Plugin.HttpTransferTasks;
using ReactiveUI.Fody.Helpers;
using System.Net.Http;
using HttpTracer;

namespace SqliteGenerationXamarin.Services
{
    public class SQLiteFactory : ISQLiteFactory
    {
        private Action<string> _messageUpdateAction;
        private readonly string _databasePath;
        private readonly IHttpTransferTasks _httpTransferTask;
        private IHttpTask DownloadSqliteTask { get; set; }

        bool DoesLocalDbExists => File.Exists(_databasePath);

        [Reactive] public bool DownloadCompleted { get; private set; }

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
                    await Task.Delay(100);
                }
            }
        }

        private async Task<string> RequestSqliteGenerationAndDownloadUrl()
        {
            _messageUpdateAction("Generating DB on the cloud...");

            HttpResponseMessage result;
            using (HttpClient client = new HttpClient(new HttpTracerHandler()))
            {
                result = await client.GetAsync("http://10.211.55.3:49787/api/data/generateSqlite");
            }

            if (result.IsSuccessStatusCode)
                return await result.Content.ReadAsStringAsync();

            throw new Exception("Could not Generate sqlite on the cloud.");
        }

        private void DownloadSqliteFile(string downloadUrl)
        {
            DownloadSqliteTask = _httpTransferTask.Download(downloadUrl.Replace("\"", ""));

            DownloadSqliteTask.PropertyChanged += (sender, args) =>
            {
                if (DownloadSqliteTask.Status == Plugin.HttpTransferTasks.TaskStatus.Completed)
                {
                    //_fileService.MoveFile(DownloadSqliteTask.LocalFilePath, Path.Combine(_fileService.PersonalPath, Constants.SyncStoreName));
                    //DownloadCompleted = true;
                }
            };
        }
    }
}
