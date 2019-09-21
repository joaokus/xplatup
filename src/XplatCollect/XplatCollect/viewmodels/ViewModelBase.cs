using System;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace XplatCollect.viewmodels
{
    public abstract class ViewModelBase : BindableBase, IInitializeAsync
    {

        protected readonly IPageDialogService pageDialogService;
        protected readonly INavigationService navigationService;

        private bool isBusy;

        protected ViewModelBase(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            this.navigationService = navigationService;
            this.navigationService = navigationService;
        }

        public virtual Task InitializeAsync(INavigationParameters parameters) => Task.CompletedTask;

        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

        public bool isNotBusy => !IsBusy;

        protected async Task ExecuteBusyAction(Func<Task> theBusyAction)
        {
            try
            {
                if (IsBusy)
                    return;

                IsBusy = true;

                await theBusyAction();

            } catch (Exception e)
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine(e);
#endif
            } finally
            {
                IsBusy = false;
            }         
        }
    }
}
