
using Microsoft.AspNetCore.Mvc;
using MovieMission6.Models;


namespace MovieMission6.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;
        public HomeController(MovieContext name)
        {
            _context = name;
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
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        //    var categories = _context.Categories.ToList();
        //    return View("Collection");
        //}

        [HttpPost]
        public IActionResult Collection(NewMovie newMovie)
        {
            //_content.NewMovie.Add(newMovie);
            _context.MovieCollection.Add(newMovie);
            _context.SaveChanges();

            return View("Confirmation", newMovie);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Full_Collection()
        {

            var movies = _context.MovieCollection
                .Where(m => m.Title != null)
                .OrderBy(m => m.Title)
                .ToList();

            return View(movies);
        
            ////var movies = _content.MovieCollection.ToList();
            ////return View(movies);
            //if (ModelState.IsValid)
            //{
            //    var movies = _context.MovieCollection
            //        .Where(m => m.Title != null)
            //        .OrderBy(m => m.Title).ToList();
            //    return View(movies);
            //}
            //else
            //{
            //    return View("NewMovie");
            //}
                
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.MovieCollection.Where(m => m.MovieId == id);

            ViewBag.Categories = _context.Categories.ToList();
            return View("Collection", recordToEdit);
        }
        [HttpPost]
        public IActionResult Edit(NewMovie newMovie)
        {
            _context.MovieCollection.Update(newMovie);
            _context.SaveChanges();
            return RedirectToAction("FullCollection");
        }

        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.MovieCollection.SingleOrDefault(m => m.MovieId == id);


            return View(recordToDelete);

        }
        [HttpPost]
        public IActionResult Delete(NewMovie newMovie)
        {
            _context.MovieCollection.Remove(newMovie);
            _context.SaveChanges();

            return RedirectToAction("FullCollection");
        }
    }
}
