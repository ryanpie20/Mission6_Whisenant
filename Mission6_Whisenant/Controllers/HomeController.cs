using Microsoft.AspNetCore.Mvc;
using Mission6_Whisenant.Models;
using System.Diagnostics;

namespace Mission6_Whisenant.Controllers
{
    public class HomeController : Controller
    {

        private MovieCollectionContext _context;

        public HomeController(MovieCollectionContext temp)
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
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(MovieCollection response)
        {
            _context.MovieCollections.Add(response);
            _context.SaveChanges(); 

            return View("Confirmation", response);
        }

    }
}
