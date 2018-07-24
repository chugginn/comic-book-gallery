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
        // ActionResult type is parent to Redirect and Content types
        public ActionResult Detail()
        {
            return View();
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