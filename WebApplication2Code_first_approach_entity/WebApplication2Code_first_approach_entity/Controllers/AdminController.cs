using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2Code_first_approach_entity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(String t1, String t2)
        {
            if( t1.Equals("Admin") && t2.Equals("Admin@123"))
            {
                return RedirectToAction("AdminDashboard", "Admin");
            }
            
            
                ViewBag.msg = "Invalid Credentials";
            
                return View();
        }
        public ActionResult AdminDashboard()
        {
            return View();
        }
    }
}
