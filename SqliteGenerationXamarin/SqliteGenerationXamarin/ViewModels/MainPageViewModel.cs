using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using DynamicData;
using Prism.Navigation;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using SqliteGeneration.Core;
using SqliteGenerationXamarin.Services;
using Xamarin.Forms;

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

            this.DownloadSqliteCommand = ReactiveCommand.CreateFromTask(async () =>
           {
               IsDownloading = true;
               // SHOW USER DIALOG TO SHOW DOWNLOAD PROCESS

               using (var dlg = this._userDialogs.Loading("Preparing to download..."))
               {
                   // START DOWNLOAD
                   await _sqliteFactory.DownloadSqlite((status) =>
                  {
                      Device.BeginInvokeOnMainThread(() =>
                      {
                          dlg.Title = status;
                      });
                  });
               }

               this.DoesLocalDbExists = true;
               this.IsDownloading = false;

           }, this.WhenAny(
                    x => x.IsDownloading,
                    x => x.DoesLocalDbExists,
                    (isDownloading, doesLocalDbExists) =>
                        isDownloading.GetValue() ||
                        !doesLocalDbExists.GetValue()));

            this.DeleteSqliteCommand = ReactiveCommand.Create(() =>
            {
                _sqliteFactory.DeleteSqliteFile();
                DoesLocalDbExists = false;
                Todos = new List<TodoItem>();

            }, this.WhenAny(
                    x => x.DoesLocalDbExists,
                    (doesLocalDbExists) =>
                        doesLocalDbExists.GetValue()));

            ResfreshCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                IsRefreshing = true;
                Todos = await _sqliteFactory.FetchTodoData();
                IsRefreshing = false;
            });

            this.WhenAnyValue(x => x.Todos)
                .SubOnMainThread(todos => Todos = todos);
        }
        

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            this.IsDownloading = false;
            this.DoesLocalDbExists = _sqliteFactory.DoesLocalDbExists;
        }

        [Reactive] public bool IsDownloading { get; private set; }
        [Reactive] public bool IsRefreshing { get; private set; }
        [Reactive] public bool DoesLocalDbExists { get; private set; }
        [Reactive] public List<TodoItem> Todos { get; private set; }

        public ReactiveCommand<Unit, Unit> DownloadSqliteCommand { get; }
        public ICommand DeleteSqliteCommand { get; }
        public ReactiveCommand<Unit, Unit> ResfreshCommand { get; }
    }
}
