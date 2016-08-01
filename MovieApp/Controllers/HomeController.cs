using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private MoviesDBEntities _db = new MoviesDBEntities();
        public ActionResult Index()
        {
            return View(_db.Movies.ToList());
        }

    }
}
