using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Theater.Models;
using Theater.ViewModels;

namespace Theater.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "The Dark Knight" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Khanom" },
                new Customer { Name = "Atiq" },
                new Customer { Name = "Sumu" },
                new Customer { Name = "Tithi" }
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return View();
        }
    }
}