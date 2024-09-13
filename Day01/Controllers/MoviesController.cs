using Microsoft.AspNetCore.Mvc;

namespace Day01.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult GetMovie(int id)
        {
            return Content($"Movie With Id = {id}");
        }
        public IActionResult Index()
        {
            //ContentResult result = new ContentResult();
            //result.Content = "Hello from Index";
            ////result.ContentType = "text/html"; //default
            ////result.ContentType = "object/pdf";
            //return result;
            return Content("Hello From Index", "text/html");
        }
        public IActionResult Test()
        {
            //RedirectResult result = new RedirectResult("https://localhost:44353/Movies/index");
            //return result;
            //return RedirectToAction(nameof(Index));
            return RedirectToRoute(new {Controller = "Movies" , action = "Index"});

        }
    }
}
