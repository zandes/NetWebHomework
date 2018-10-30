using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutsLab.Controllers
{
    public class FreeController : Controller
    {
        // GET: Free
        public ActionResult Bird(string name = "Unknown", int? age = -1, string color = "N/A")
        {
            ViewBag.name = name;
            ViewBag.age = age;
            ViewBag.color = color;
            return View();
        }
    }
}