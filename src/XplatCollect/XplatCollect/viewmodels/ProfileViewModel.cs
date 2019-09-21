using Prism.Navigation;
using Prism.Services;

namespace XplatCollect.viewmodels
{
    public sealed class ProfileViewModel : ViewModelBase
    {
        public ProfileViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {

        }
    }
}
