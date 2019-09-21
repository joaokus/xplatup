using Prism.Navigation;
using Prism.Services;

namespace XplatCollect.viewmodels
{
    public sealed class NewCollectionViewModel : ViewModelBase
    {
        public NewCollectionViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {

        }
    }
}
