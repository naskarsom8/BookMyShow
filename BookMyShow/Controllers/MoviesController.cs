using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookMyShow.Models;
using BookMyShow.ViewModels;

namespace BookMyShow.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {
            var movie = new Movie()
            {
                Name = "Movies"
            };

            //var movies = new List<Movie>
            //{
            //    new Movie {Name = "Avengers"},
            //    new Movie {Name = "Padmavat"}
            //};

            var viewModel = new RandomMovieViewModel
            {
                Movies = new List<Movie>
                {
                    new Movie { Id = 1, Name = "Avengers" },
                    new Movie { Id = 2, Name = "Padmavat" }
                }
            };
            
            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //The third argument is the anonymous type that will be displayed in the URL.
            //return RedirectToAction("Index", "Home", new { page = 1, srotBy = "name"});
        }

        public ActionResult Edit(int id)
        {
            return Content("Id=" + id);
        }

        ////Movies default page
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}