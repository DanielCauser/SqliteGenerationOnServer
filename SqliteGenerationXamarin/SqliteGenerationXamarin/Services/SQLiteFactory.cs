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
using System.Reactive.Linq;
using System.ComponentModel;

namespace SqliteGenerationXamarin.Services
{
    public class Download
    {
        public decimal Progress { get; internal set; }
        public TimeSpan TimeLeft { get; internal set; }
        public double DownloadSpeedBytes { get; internal set; }
        public long FileSize { get; internal set; }
        public long BytesDownloads { get; internal set; }
    }

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


        public IObservable<Download> DownloadSomeShit() => Observable.Create<Download>(async ob =>
        {

            DeleteSqliteFile();
            var url = await this.RequestSqliteGenerationAndDownloadUrl();
            var task = _httpTransferTask.Download(url.Replace("\"", ""));
            var progress = new Download();

            var handler = new PropertyChangedEventHandler((sender, args) =>
            {
                switch (task.Status)
                {
                    case Plugin.HttpTransferTasks.TaskStatus.Error:
                        ob.OnError(task.Exception);
                        break;

                    case Plugin.HttpTransferTasks.TaskStatus.Completed:
                        ob.OnCompleted();
                        break;

                    default:
                        progress.FileSize = task.FileSize;
                        progress.DownloadSpeedBytes = task.BytesPerSecond;
                        progress.Progress = task.PercentComplete;
                        progress.TimeLeft = task.EstimatedCompletionTime;
                        progress.BytesDownloads = task.BytesTransferred;

                        ob.OnNext(progress); 
                        break;
                }
            });

            task.PropertyChanged += handler;

            return () => {
                task.PropertyChanged -= handler;
            }; // double fuck off
        })
        .Sample(TimeSpan.FromSeconds(1));


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
        }

        private async Task<string> RequestSqliteGenerationAndDownloadUrl()
        {
            //HttpResponseMessage result;
            //using (HttpClient client = new HttpClient(new HttpTracerHandler()))
            //{
            //    result = await client.GetAsync("http://10.211.55.3:49787/api/data/generateSqlite");
            //}

            return "https://bsistoragedemocauser.blob.core.windows.net/sqlitefile/fuckoffshahab.db";
            //result.EnsureSuccessStatusCode();
            //return await result.Content.ReadAsStringAsync();
            //if (result.IsSuccessStatusCode)
            //    return await result.Content.ReadAsStringAsync();

            //throw new Exception("Could not Generate sqlite on the cloud.");
        }

        private void DownloadSqliteFile(string downloadUrl)
        {
            DownloadSqliteTask = _httpTransferTask.Download(downloadUrl.Replace("\"", ""));

            DownloadSqliteTask.PropertyChanged += (sender, args) =>
            {
                if (DownloadSqliteTask.Status == Plugin.HttpTransferTasks.TaskStatus.Completed)
                {
                    File.Move(DownloadSqliteTask.LocalFilePath, _databasePath);
                    DownloadCompleted = true;
                }
            };
        }

        public void DeleteSqliteFile()
        {
            if (File.Exists(_databasePath))
                File.Delete(_databasePath);
        }

        public List<TodoItem> FetchTodoData()
        {
            if(DoesLocalDbExists)
            {
                var db = new SQLiteConnection(_databasePath, true);
                var result = db.Query<TodoItem>("select * from TodoItem");
                return result;
            }
            return new List<TodoItem>();
        }
    }
}
