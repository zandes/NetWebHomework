using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Stuff(int? id, string name)
        {
            ViewBag.name = name;
            ViewBag.number = id;
            return View();
        }

        public ActionResult AddNumbers(FormCollection Form)
        {
            double num1, num2;

            if (Double.TryParse(Form["num1"], out num1) && Double.TryParse(Form["num2"], out num2))
            {
                ViewBag.Total = num1 + num2;
            }
            else
            {
                ViewBag.Total = "Invalid";
            }
            return View();
        }

        public ActionResult DisplayList()
        {
            string[] names = {"Jeff", "Bob", "Mary"};
            ViewBag.names = names;
            return View();
        }

        public ActionResult Colors()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Colors(FormCollection Form)
        {
            string color1 = Form["color1"];
            string color2 = Form["color2"];
            string finalColor = null;

            if (color1.Equals("Red"))
            {
                if (color2.Equals("Red"))
                {
                    finalColor = "Red";
                }else if (color2.Equals("Green"))
                {
                    finalColor = "Yellow";
                }else if (color2.Equals("Blue"))
                {
                    finalColor = "Magenta";
                }
            }else if (color1.Equals("Green"))
            {
                if (color2.Equals("Red"))
                {
                    finalColor = "Yellow";
                }else if (color2.Equals("Green"))
                {
                    finalColor = "Green";
                }else if (color2.Equals("Blue"))
                {
                    finalColor = "Cyan";
                }
            }else if (color1.Equals("Blue"))
            {
                if (color2.Equals("Red"))
                {
                    finalColor = "Magenta";
                }else if (color2.Equals("Green"))
                {
                    finalColor = "Cyan";
                }else if (color2.Equals("Blue"))
                {
                    finalColor = "Blue";
                }
            }

            if (finalColor != null)
            {
                ViewBag.colorResult = color1 + " and " + color2 + " makes " + finalColor;
            }

            return View();
        }
		
		string[] balloons = {"Red", "Blue", "Green", "Purple"};
        public ActionResult Birthday()
        {
            ViewBag.balloons = balloons;
            return View();
        }

        [HttpPost]
        public ActionResult Birthday(FormCollection Form)
        {
            List<string> list = new List<string>();

            foreach (var balloon in balloons)
            {
                bool isChecked = Convert.ToBoolean(Form[balloon].Split(',')[0]);
                if (isChecked)
                {
                    list.Add(balloon);
                }
            }

            ViewBag.list = list;
            ViewBag.name = Form["name"];
            ViewBag.birthday = Form["birthday"];
            return View("Results");
        }
    }
}