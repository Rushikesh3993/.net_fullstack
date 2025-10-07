using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationWIthMVC_Lossley_Strongly.Models;

namespace WebApplicationWIthMVC_Lossley_Strongly.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Customer c1 = new Customer();
            c1.cid = 101;
            c1.cname = "Rushi";
            c1.cemail = "Rushi@gmail.com";

            //ViewBag.obj = c1;
            Customer c2 = new Customer();
            c2.cid = 201;
            c2.cname = "Raghav";
            c2.cemail = "Raghav@gmail.com";

            Customer c3 = new Customer();
            c3.cid = 301;
            c3.cname = "Rahul";
            c3.cemail = "Rahul@gmail.com";

            Customer c4 = new Customer();
            c4.cid = 401;
            c4.cname = "Harsh";
            c4.cemail = "Harsh@gmail.com";

            List <Customer> a1 = new List <Customer>();
            a1.Add(c1);
            a1.Add(c2);
            a1.Add(c3);
            a1.Add(c4);

            return View(a1);
        }
    }
}