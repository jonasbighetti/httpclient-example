using HttpClientExample.API.Configuration.Interface;
using HttpClientExample.API.Models;
using HttpClientExample.API.Services.Interface;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HttpClientExample.API.Services
{
    public class PostService : IPostService
    {
        private readonly IApiConfig _apiConfig;
        private readonly HttpClient _httpClient;

        public PostService(IApiConfig apiConfig, HttpClient httpClient)
        {
            _apiConfig = apiConfig;
            _httpClient = httpClient;
        }

        public async Task<PostModel> GetPost(int id)
        {
            return await _httpClient.GetFromJsonAsync<PostModel>($"{_apiConfig.BaseUrl}/posts/{id}");
        }
    }
}
