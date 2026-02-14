using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieMission6.Models;

namespace MovieMission6.Controllers
{
    public class HomeController : Controller
    {
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
            return View(newMovie);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    }
}
