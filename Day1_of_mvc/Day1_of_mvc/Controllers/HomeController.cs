using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1_of_mvc.Controllers
{
    public class HomeController : Controller //inheritance homecontroller extend the controller.
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}