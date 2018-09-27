using System.Threading.Tasks;
using XFDesktopMVVM.ViewModels;

namespace XFDesktopMVVM.Services.NavigationService
{
    public interface INavigationService
    {
        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;

        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;

        Task NavigateToModalAsync<TViewModel>(object parameter = null, bool animate = true) where TViewModel : ViewModelBase;

        Task NavigateBackAsync();

        Task NavigateBackFromModalAsync();
    }
}
