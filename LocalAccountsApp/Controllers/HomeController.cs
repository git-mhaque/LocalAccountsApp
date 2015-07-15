using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocalAccountsApp.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page (Knockout)";

            return View();
        }

        public ActionResult Angular()
        {
            ViewBag.Title = "Home Page (AngularJS)";

            return View("Index-Angular");
        }
                                                                            
    
    }

}
