using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1DatabaseApproach.Models;

namespace WebApplication1DatabaseApproach.Controllers
{
    public class OrderController : Controller
    {

      public  restroEntities r1 = new restroEntities();

        // GET: Order
        public ActionResult Index()
        {

            return View();
        }
    }
}