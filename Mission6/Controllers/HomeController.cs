using Microsoft.AspNetCore.Mvc;
using Mission06_Boody.Models;
using System.Diagnostics;

namespace Mission06_Boody.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View();


        }

        [HttpPost]
        public IActionResult Form(Movie response)
        {
            ViewData["response"] = response;

            return View("Confirmation");
        }

    }
}
