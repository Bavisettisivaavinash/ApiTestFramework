using System.Net.Http;

namespace ApiTestFramework.Clients
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // API client methods will go here
    }
}