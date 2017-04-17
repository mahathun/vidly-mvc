using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        public List<Movie> movies = new List<Movie>() {
                new Movie(){Id=1, Name="Shrek"},
                new Movie(){Id=2, Name="Killer Elite"},
        };

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Id=1, Name="Shrek" };
            var customers = new List<Customer>
            {
                new Customer(){Id=1, Name="John"},
                new Customer(){Id=2, Name="Peter"}
            };

            var viewModel = new RandomMovieViewModel() { Customers = customers, Movie = movie };
            return View(viewModel);
        }

        public ActionResult Index()
        {
            var movieList = new IndexMoviesViewModel() { Movies = movies };

            return View(movieList);
        }

        [Route("movies/release/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult Release(int year, int month)
        {

            return Content(String.Format("Year : {0} <br> Month : {1}",year,month));
        }
    }
}