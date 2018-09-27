using System.Net.Http;
using System.Threading.Tasks;

namespace XFDesktopMVVM.Helpers
{
    public static class HttpClientHelper
    {
        /// <summary>
        /// HttpClient GET
        /// </summary>
        /// <param name="uri">Query String</param>
        /// <returns>Json object or null</returns>
        public static async Task<object> GetAsync(string uri)
        {
            HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetAsync(uri);

            var responseContent = response.Content.ReadAsStringAsync().Result;
            return responseContent;
        }
    }
}
