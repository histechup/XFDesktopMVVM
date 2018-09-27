using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XFDesktopMVVM.Models
{
    public class Post
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        //ImageURL is getter only property
        public string ImageUrl => $"https://picsum.photos/70/?image={Id}";
    }
}
