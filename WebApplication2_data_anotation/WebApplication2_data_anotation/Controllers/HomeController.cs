using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2_data_anotation.Models;

namespace WebApplication2_data_anotation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // ✅ Single GET version (load form + show success message)
        [HttpGet]
        public ActionResult StudentRegister()
        {
            if (TempData["SuccessMsg"] != null)
            {
                ViewBag.sus = TempData["SuccessMsg"].ToString();
            }
            return View();
        }

        // ✅ POST version (insert into DB)
        [HttpPost]
        public ActionResult StudentRegister(Student s1)
        {
            if (ModelState.IsValid)
            {
                string path = "Data Source=LAPTOP-J203V7TL\\SQLEXPRESS; Initial Catalog=DataAnnotation; Trusted_Connection=True;";
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO data (sid, sname, semail, sage, spass, scpass, sdate) VALUES (@sid, @sname, @semail, @sage, @spass, @scpass, @sdate)",
                        con
                    );

                    cmd.Parameters.AddWithValue("@sid", s1.sid);
                    cmd.Parameters.AddWithValue("@sname", s1.sname);
                    cmd.Parameters.AddWithValue("@semail", s1.semail);
                    cmd.Parameters.AddWithValue("@sage", s1.sage);
                    cmd.Parameters.AddWithValue("@spass", s1.spass);
                    cmd.Parameters.AddWithValue("@scpass", s1.scpass);
                    cmd.Parameters.AddWithValue("@sdate", s1.sdate);

                    cmd.ExecuteNonQuery();
                }

                TempData["SuccessMsg"] = "✅ Registration Successful!";
                return RedirectToAction("StudentRegister");
            }

            // ❌ Validation failed
            return View(s1);
        }
    }
}
