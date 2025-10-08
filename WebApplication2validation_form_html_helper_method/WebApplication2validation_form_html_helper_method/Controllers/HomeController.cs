using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2validation_form_html_helper_method.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(String t1,String t2, String t3)
        {
            if (t1.Equals("")==true)
            {
                ModelState.AddModelError("t1", "please Enter Username");
            }

            if (t2.Equals("")==true)
            {
                ModelState.AddModelError("t2", "Please enter email");
            }

            if (t3.Equals("") == true)
            {
                ModelState.AddModelError("t3", "Please enter pass");
            }

            if (ModelState.IsValid==true)
            {
                @ViewBag.sus = "Registration Complete";

            }
            return View();
        }
    }
}