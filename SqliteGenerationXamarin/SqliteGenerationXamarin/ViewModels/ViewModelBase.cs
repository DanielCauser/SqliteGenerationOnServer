using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using System.Threading.Tasks;
using Prism.AppModel;

namespace SqliteGenerationXamarin.ViewModels
{
    public class ViewModelBase : ReactiveObject,
                                      INavigatingAware,
                                      INavigatedAware,
                                      IDestructible,
                                      IPageLifecycleAware,
                                      IConfirmNavigationAsync
    {
        protected INavigationService NavigationService { get; private set; }

        [Reactive] public string Title { get; set; }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }

        public virtual Task<bool> CanNavigateAsync(INavigationParameters parameters) => Task.FromResult(true);


        public virtual void OnAppearing()
        {
        }

        public virtual void OnDisappearing()
        {
        }
    }
}
