using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieMission6.Models;

namespace MovieMission6.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _content;
        public HomeController(MovieContext name) 
        {
            _content = name;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Info()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Collection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Collection(NewMovie newMovie)
        {
            //_content.NewMovie.Add(newMovie);
            _content.MovieCollection.Add(newMovie);
            _content.SaveChanges();

            return View("Confirmation", newMovie);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    }
}
