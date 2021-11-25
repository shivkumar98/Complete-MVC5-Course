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
      

        // Get: Random Movie
        public ActionResult Random()
        {

            Movie movie = new Movie() { Name = "Shrek" };
            //return Content("hellow world); returns plain text
            return RedirectToAction("Index", "Home", new { page = 1 });
        }

        //action result ecample
        public ActionResult Edit(int id)
        {
            return Content(id +"hello" );
        }


        // /movie
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue) ;
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}