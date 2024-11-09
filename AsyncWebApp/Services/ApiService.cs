// Services/ApiService.cs
using AsyncWebApp.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AsyncWebApp.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Post>> GetPostsAsync()
        {
            // Fetch data asynchronously
            HttpResponseMessage response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");

            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Post>>(jsonResponse);
        }
    }
}
