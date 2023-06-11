using m1.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace m1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {
            ViewBag.Name = "Company: TechSolutions";
            ViewBag.Bio = "TechSolutions is a leading IT consulting firm specializing in software development, cybersecurity, and cloud solutions for businesses worldwide.";
            return View();
            
        }

        public ActionResult Service()
        {
            ViewBag.Message = "Your application Service page.";
            ViewBag.S1 = "Software Development";

            ViewBag.S2 = "Cybersecurity Solutions";

            ViewBag.S3 = "Cloud Solutions";

            return View();
        }
        public ActionResult Members()
        {
            ViewBag.Message = "Your application Members page.";
            var e1 = new Members()
            {
                Name = "Sabrina",
                DOB = "6/1/2000",
                BG = "A+"

            };
            var e2 = new Members()
            {
                Name = "Muhee",
                DOB = "6/1/2001",
                BG = "AB+"

            };
          
            Members[] eds = new Members[] { e1, e2 };

            return View(eds);
            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}