using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            // store the movie categories as a list
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        // Saving a new movie
        [HttpPost]
        public IActionResult MovieForm(Movie response) {

            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("Added");
        }

        // Pass all movies as a list to the MovieTable view
        public IActionResult MovieTable()
        {
            // save the movies to a list and include their respective categories from the linked categories table
            var movies = _context.Movies
                .Include(m => m.Category)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        // When user requests to edit, pass the info of what record to edit to the movie form page
        public IActionResult Edit(int id)
        {
            var movie = _context.Movies.Single(x => x.MovieID == id);
            ViewBag.Categories = _context.Categories.ToList();

            return View("MovieForm", movie);
        }
        [HttpPost]
        // Update the edited movie
        public IActionResult Edit(Movie updatedMovie)
        {
            _context.Update(updatedMovie);
            _context.SaveChanges();
            return RedirectToAction("MovieTable");
        }

        [HttpGet]
        // When user requests to delete, return the delete confirmation view
        // pass the movie object the user wants to delete to this view
        public IActionResult Delete(int id)
        {
            var movie = _context.Movies.Single(x => x.MovieID == id);
            return View(movie);
        }

        [HttpPost]
        // Remove the record

        public IActionResult Delete(Movie delMovie)
        {
            _context.Remove(delMovie);
            _context.SaveChanges();
            return RedirectToAction("MovieTable");
        }
    }
}
