using Microsoft.AspNetCore.Mvc;
using Mission06_Boody.Models;
using Microsoft.EntityFrameworkCore;

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

        //• Add movies to his collection
        [HttpGet]
        public IActionResult Form()
        {
            ViewBag.Categories = _context.Categories.OrderBy(x=> x.CategoryName).ToList();
            return View("Form", new Movie());
        }

        [HttpPost]
        public IActionResult Form(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();
            
            return View("Confirmation");
            }
            else 
            //invalid - return the form with the data the user entered
            {
                ViewBag.Categories = _context.Categories.OrderBy(x=> x.CategoryName).ToList();
                return View(response);
            }
        }

        //• View a list of all movies in his collection

        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = _context.Movies.Include("Category").ToList();
            return View(movies);
        }

        //• Edit movies in his collection

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movieToEdit = _context.Movies.Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories.OrderBy(x=> x.CategoryName).ToList();
            return View("Form",movieToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }

        //• Delete movies from his collection


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movieToDelete = _context.Movies.Single(x => x.MovieId == id);
            return View(movieToDelete);
        }
        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
