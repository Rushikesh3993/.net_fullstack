using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1API.Controllers
{
    public class CustomerUiController : Controller
    {
        // GET: CustomerUi
        public ActionResult Index()
        {
            return View();
        }
    }
}