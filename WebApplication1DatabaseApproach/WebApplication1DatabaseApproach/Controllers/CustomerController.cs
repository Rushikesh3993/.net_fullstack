using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1DatabaseApproach.Models;

namespace WebApplication1DatabaseApproach.Controllers
{
    public class CustomerController : Controller
    {

        restroEntities r1 = new restroEntities();

        // GET: Home
        public ActionResult Index()
        {
            var x=r1.customers.ToList();
            return View();
        }
    }
}