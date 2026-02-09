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


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        
    }
}
