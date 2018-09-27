using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XFDesktopMVVM.Models;

namespace XFDesktopMVVM.Services.PostDataService
{
    public interface IPostDataService
    {
        Task<List<Post>> GetPostsAsync();
    }
}
