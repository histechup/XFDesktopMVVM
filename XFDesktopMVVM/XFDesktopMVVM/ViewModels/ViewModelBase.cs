using System.Threading.Tasks;
using Xamarin.Forms;
using XFDesktopMVVM.Services.NavigationService;
using XFDesktopMVVM.ViewModels.Base;

namespace XFDesktopMVVM.ViewModels
{
    public class ViewModelBase: BindableObject
    {
        protected readonly INavigationService NavigationService;
        protected ViewModelBase()
        {
           NavigationService = Locator.Instance.Resolve<INavigationService>();

        }

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }

    }
}
