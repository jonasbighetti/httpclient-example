using HttpClientExample.API.Configuration.Interface;

namespace HttpClientExample.API.Configuration
{
    public class ApiConfig : IApiConfig
    {
        public string BaseUrl { get; set; }
    }
}
