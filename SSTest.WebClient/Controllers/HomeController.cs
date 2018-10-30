using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSTest.WebClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            //new changes
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //Comments
            //coment by vijay
            
            //new changes for conflict1
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
