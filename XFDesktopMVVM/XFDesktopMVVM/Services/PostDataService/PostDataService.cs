using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using XFDesktopMVVM.Helpers;
using XFDesktopMVVM.Models;

namespace XFDesktopMVVM.Services.PostDataService
{
    public class PostDataService : IPostDataService
    {
        const string BASE_URL = "https://jsonplaceholder.typicode.com/";
        const string POST_ENDPOINT = "posts";
        public async Task<List<Post>> GetPostsAsync()
        {
            try
            {
                var result = await HttpClientHelper.GetAsync(BASE_URL + POST_ENDPOINT);
                return JsonConvert.DeserializeObject<List<Post>>(result.ToString());
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
            }

            return null;
        }
    }
}
