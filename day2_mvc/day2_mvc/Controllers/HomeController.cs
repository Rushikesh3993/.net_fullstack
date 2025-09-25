using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace day2_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            ViewData["x"] = "Hello Mvc From View Data";
            int a = 10, b = 23, c;
            c = a + b;
            ViewData["y"] = c;

            int[] arr = { 10, 20, 30, 40, 50 };

            ViewData["z"] = arr;

            int[] a1 = { 90, 34, 56, 22, 11 };

            ViewData["d"] = a1;

            String[] nm = { "Rushikesh", "Arati", "Sanika", "Prem", "Soham" };
            ViewData["f"] = nm;

            Models.Staff s1 = new Models.Staff();
            s1.sid = 101;
            s1.sname = "RushikeshM";
            s1.semail = "Rushikesh@gmail.com";

            ViewData["m"] = s1;

            return View();
        }
    }
}