using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureSQLDatabaseAndService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            // Added GitHub Comment#1 // Added GitHub Comment#4
            // Added GitHub Comment#1 //// Added GitHub Comment#3
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
             // Added GitHub Comment#2 // Added GitHub Comment#6
            return View();
        }
    }
}
