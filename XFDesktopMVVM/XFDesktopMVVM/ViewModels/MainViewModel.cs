using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XFDesktopMVVM.Models;
using XFDesktopMVVM.Services.PostDataService;

namespace XFDesktopMVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IPostDataService _postDataService;

        public MainViewModel(IPostDataService postDataService)
        {
            _postDataService = postDataService;
            Posts = new ObservableCollection<Post>();
        }
        public ObservableCollection<Post> Posts { get; set; }

        private Post _selectedPost;
        public Post SelectedPost
        {
            get => _selectedPost;
            set
         {
                _selectedPost = value;
                OnPropertyChanged();
                if (_selectedPost == null) return;
                NavigateToPostDetail();


            }
        }

        public ICommand UpdatePostsCommand => new Command(async () => await ExecuteUpdatePostsCommand());

        private async void NavigateToPostDetail()
        {
            await NavigationService.NavigateToAsync<PostDetailViewModel>();
        }

       async Task ExecuteUpdatePostsCommand()
        {
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                Posts.Clear();
                var newPosts = await _postDataService.GetPostsAsync();
                foreach (var item in newPosts)
                {
                    Posts.Add(item);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
