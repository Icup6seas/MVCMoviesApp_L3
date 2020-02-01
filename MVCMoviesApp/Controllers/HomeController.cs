using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMoviesApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to the MoviesApp! Here we hold all of your movies!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Currently only supported by no one...";

            return View();
        }
    }
}