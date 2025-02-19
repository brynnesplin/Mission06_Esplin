using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Esplin.Models;

namespace Mission06_Esplin.Controllers
{
    public class HomeController : Controller
    {
        private MovieRatingContext _context;
        public HomeController(MovieRatingContext temp)
        {
            _context = temp;

        }
        // Home View
        public IActionResult Index()
        {
            return View();
        }
        // Get to Know Joel View
        public IActionResult GetToKnowJoel()
        {
            return View();
        }
        //Movie Form View
        public IActionResult MovieForm()
        {
            return View();
        }

        // Saving a new movie
        [HttpPost]
        public IActionResult MovieForm(Movie response) {

            // Success Message
            Console.WriteLine("MovieRating method was hit!");

            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("Added");
        }


    }
}
