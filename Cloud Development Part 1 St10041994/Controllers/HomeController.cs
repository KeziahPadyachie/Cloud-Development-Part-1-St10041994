using Cloud_Development_Part_1_St10041994.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace KhumaloCraft.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();

        }

        public IActionResult Contact()
        {
            return View();

        }
    }
}
    

