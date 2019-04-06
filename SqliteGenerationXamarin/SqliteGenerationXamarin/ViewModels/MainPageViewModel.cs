using System.Collections.Generic;
using System.Reactive.Concurrency;
using System.Windows.Input;
using Acr.UserDialogs;
using Prism.Navigation;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using SqliteGeneration.Core;
using SqliteGenerationXamarin.Services;
using Xamarin.Forms;
using System.Reactive.Linq;
using System.Reactive;
using System;
using Humanizer;


namespace SqliteGenerationXamarin.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ISQLiteFactory _sqliteFactory;
        private readonly IUserDialogs _userDialogs;

        public MainPageViewModel(INavigationService navigationService,
                                    ISQLiteFactory sqliteFactory,
                                    IUserDialogs userDialogs)
            : base(navigationService)
        {
            Title = "Main Page";

            _sqliteFactory = sqliteFactory;
            _userDialogs = userDialogs;
            Todos = new List<TodoItem>();


            this.DownloadSqliteCommand = ReactiveCommand.Create(() =>
            {
                var dlg = this._userDialogs.Progress("Preparing to download...");
                _sqliteFactory
                    .DownloadSomeShit()
                    .Subscribe
                    (
                        x => {

                            var kbs = x.DownloadSpeedBytes.Kilobytes();
                            var mins = x.TimeLeft.Humanize();

                            dlg.Title = $"Mins Left: {mins} - {kbs} kb/s";
                            dlg.PercentComplete = Convert.ToInt32(x.Progress);
                        },
                        ex => {
                            dlg.Dispose();
                            _userDialogs.Alert(ex.ToString(), "Fuck off shahab");
                        },
                        () => {
                            dlg.Dispose();
                            _userDialogs.Alert("FUCK YA");
                            //Todos = _sqliteFactory.FetchTodoData();
                        }
                    );
            });
           // this.DownloadSqliteCommand = ReactiveCommand.CreateFromTask(async () =>
           //{
           //    IsDownloading = true;
           //    // SHOW USER DIALOG TO SHOW DOWNLOAD PROCESS

           //    using (var dlg = this._userDialogs.Loading("Preparing to download..."))
           //    {
           //        // START DOWNLOAD
           //        await _sqliteFactory.DownloadSqlite((status) =>
           //       {
           //           Device.BeginInvokeOnMainThread(() =>
           //           {
           //               dlg.Title = status;
           //           });
           //       }).ConfigureAwait(false);

           //        Todos = _sqliteFactory.FetchTodoData();
           //    }

           //    Device.BeginInvokeOnMainThread(() =>
           //    {
           //        DoesLocalDbExists = true;
           //        IsDownloading = false;
           //    });

           //}, this.WhenAny(
                    //x => x.IsDownloading,
                    //x => x.DoesLocalDbExists,
                    //(isDownloading, doesLocalDbExists) =>
                        //isDownloading.GetValue() ||
                        //!doesLocalDbExists.GetValue()));

            this.DeleteSqliteCommand = ReactiveCommand.Create(() =>
            {
                Todos = new List<TodoItem>();
                _sqliteFactory.DeleteSqliteFile();
                DoesLocalDbExists = false;
            }, this.WhenAny(
                    x => x.DoesLocalDbExists,
                    (doesLocalDbExists) =>
                        doesLocalDbExists.GetValue()));

            ResfreshCommand = ReactiveCommand.Create(() => { Todos = _sqliteFactory.FetchTodoData(); });
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            IsDownloading = false;
            Todos = _sqliteFactory.FetchTodoData();
            DoesLocalDbExists = _sqliteFactory.DoesLocalDbExists;
        }

        [Reactive] public bool IsDownloading { get; private set; }
        [Reactive] public bool DoesLocalDbExists { get; private set; }
        [Reactive] public List<TodoItem> Todos { get; private set; }

        public ICommand DownloadSqliteCommand { get; }
        public ICommand DeleteSqliteCommand { get; }
        public ICommand ResfreshCommand { get; }
    }
}
