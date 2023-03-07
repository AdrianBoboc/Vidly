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

        public ActionResult Index()
        {
            var moviesList = new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek"},
                new Movie { Id = 2, Name = "Wall-e"}
            };

            return View(moviesList);
        }

        /*//
        // GET: /Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name="Shrek!" };
            var customers = new List<Customer> 
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);       //(Forma 1 de hacerlo)

            /*
            //Forma 2 de hacerlo
            ViewData["Movie"] = movie;
            return View();
            */


            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, shortBy = "name" });
        //}

        /*public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex = {0}&sortBy={1}", pageIndex, sortBy));
        }
        //For new times (Reference to RouteConfig.cs routing)
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDAte(int year, int month)
        {
            return Content(year + "/" + month);
        }*/
	}
}