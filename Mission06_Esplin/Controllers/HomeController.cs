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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Movie response) { 
        
            Console.WriteLine("MovieRating method was hit!");

            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("Added");
        }


    }
}
