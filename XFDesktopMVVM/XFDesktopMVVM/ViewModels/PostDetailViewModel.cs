using System;
using System.Collections.Generic;
using System.Text;
using XFDesktopMVVM.Models;
using XFDesktopMVVM.ViewModels.Base;

namespace XFDesktopMVVM.ViewModels
{
    public class PostDetailViewModel: ViewModelBase
    {
        public Post Post => Locator.Instance.Resolve<MainViewModel>().SelectedPost;
    }
}
