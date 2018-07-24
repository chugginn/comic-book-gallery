using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    // all controller classes must inherit MVC Controller base class and must be public
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }

            return Content("Hello comic books detail page.");
        }
    }

    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello world.";
        }
    }
}