using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2MVC_practice.Models;

namespace WebApplication2MVC_practice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]

        public ActionResult Index(Form f1) {

            //ViewBag.x = f1.fid;
            //ViewBag.y = f1.fname;
            //ViewBag.z = f1.femail;
            //ViewBag.w = f1.fpass;

            String path = "Data Source=LAPTOP-J203V7TL\\SQLEXPRESS; Initial Catalog=Practice; Trusted_Connection=True;";

            SqlConnection con = new SqlConnection(path);
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into data values('"+f1.fid+ "','"+f1.fname+ "','"+f1.femail+"','"+f1.fpass+"')", con);

            cmd.ExecuteNonQuery();

            ViewBag.msg = "Record Save";
         return View();
        }
    }
}