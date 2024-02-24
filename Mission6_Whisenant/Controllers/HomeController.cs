using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission6_Whisenant.Models;
using SQLitePCL;
using System.Diagnostics;

namespace Mission6_Whisenant.Controllers
{
    public class HomeController : Controller
    {

        private MovieContext _context;

        public HomeController(MovieContext temp)
        {
            _context = temp;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = _context.Categories.ToList();

            return View("AddMovie", new Movie());
        }

        [HttpPost]
        public IActionResult AddMovie(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.Categories = _context.Categories.ToList();

                return View(response);
            }

            return View("Confirmation", response);
        }

        public IActionResult MovieList()
        {
            // Linq 
            //var movies = _context.Movies
            //.OrderBy(x => x.Title).ToList();
            var movies = _context.Movies.Include(m => m.Category).ToList();
            return View(movies);

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Movie recordToEdit = _context.Movies
                .SingleOrDefault(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories.ToList();

            return View("AddMovie", recordToEdit);
        }

        [HttpPost]

        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            return RedirectToAction("MovieList", "Home");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
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
