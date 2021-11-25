using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidley.Models;

namespace Vidley.Controllers
{
    public class MovieController : Controller
    {

        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }

        // Get: Random Movie
        public ActionResult Random()
        {

            Movie movie = new Movie() { Name = "Shrek" };
            return View(movie);
        }
    }
}