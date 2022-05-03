using MoviesRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesRental.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            Movies movies = new Movies()
            {
                Name = "Konosuba"
            };
            return View(movies);
        }

        public ActionResult GetID(int id)
        {
            return Content($"id = {id}");
        }

        public ActionResult ReleasedDate(int year, byte month)
        {
            return Content($"year = {year}, month = {month}");
        }
    }
}