// Controllers/HomeController.cs
using AsyncWebApp.Models;
using AsyncWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApiService _apiService;

        public HomeController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            // Fetch data asynchronously
            List<Post> posts = await _apiService.GetPostsAsync();
            return View(posts);
        }
    }
}
