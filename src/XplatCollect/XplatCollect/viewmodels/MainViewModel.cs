
using Prism.Navigation;
using Prism.Services;

namespace XplatCollect.viewmodels
{
    public sealed class MainViewModel : ViewModelBase
    {
        public MainViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {

        }

    }
}
