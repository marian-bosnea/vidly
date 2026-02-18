using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.Models.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        //GET: Movies/Random
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            var customers = new List<Customer> {
             new() { Name = "Customer 1"},
             new() { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel { 
                Movie = movie,
                Customers = customers };

       
            return View(viewModel);
        }

        [Route("movies/released/{year:int}/{month:range(1, 12)}")]
        public IActionResult ByReleaseDate(int year, int month) {
            return Content(year + "/" + month);
        }
    }
}
