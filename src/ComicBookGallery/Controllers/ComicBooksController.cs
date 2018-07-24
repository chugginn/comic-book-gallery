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
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, " +
                              "last, great act of revenge! Even if Spider-Man survives... <strong>will Peter " +
                              "Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

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