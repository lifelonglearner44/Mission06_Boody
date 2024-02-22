using Microsoft.AspNetCore.Mvc;
using Mission06_Boody.Models;

namespace Mission06_Boody.Controllers
{
    public class HomeController : Controller
    {

        private readonly MovieContext _context;

        public HomeController(MovieContext temp)
        {
            _context = temp;
        }

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
           
                _context.Movie.Add(response);
                _context.SaveChanges();
            
            ViewData["response"] = response;

            return View("Confirmation");
        }

    }
}
