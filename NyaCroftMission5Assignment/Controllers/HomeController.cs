using Microsoft.AspNetCore.Mvc;
using NyaCroftMission5Assignment.Models;
using System.Diagnostics;

namespace NyaCroftMission5Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Pull up index page
        public IActionResult Index()
        {
            return View();
        }

        // Pull up calculator page
        public IActionResult Calculator()
        {
            return View();
        }

        // Pull up contact page
        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

