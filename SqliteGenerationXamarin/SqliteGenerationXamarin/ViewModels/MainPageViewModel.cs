using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Input;
using Acr.Collections;
using Acr.UserDialogs;
using Prism.Navigation;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;
using SqliteGenerationXamarin.Services;
using System.Reactive;
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
            this.DownloadSqliteCommand = ReactiveCommand.CreateFromTask( async () =>
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
                    }).ConfigureAwait(false);
                }

                IsDownloading = false;
            }, this.WhenAny(x => x.IsDownloading, (isDownloading) => !isDownloading.GetValue()));
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
            IsLoadingData = false;
            IsDownloading = false;
        }

        [Reactive] public bool IsDownloading { get; private set; }
        [Reactive] public bool IsLoadingData { get; private set; }

        public ICommand DownloadSqliteCommand { get; }
    }
}
