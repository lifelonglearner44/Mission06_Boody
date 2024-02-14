using Microsoft.AspNetCore.Mvc;
using Mission06_Boody.Models;
using System.Diagnostics;

namespace Mission6.Controllers
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
        public IActionResult Form()
        {
            return View();


        }

        //public IActionResult DatingApplication(Application response)
        //{
        //    return View(responsel);
        //}

     
    }
}
