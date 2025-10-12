using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2Code_first_approach_entity.Models;

namespace WebApplication2Code_first_approach_entity.Controllers
{
    public class StudentController : Controller
    {
        StudentContext sk = new StudentContext();

        // GET: Student
        public ActionResult StudentRegistration()
        {

            return View();
        }

        [HttpPost]
        public ActionResult StudentRegistration(Students s1)
        {
            sk.students.Add(s1);
            sk.SaveChanges();
            TempData["SuccessMessage"] = "Record Saved Successfully!";
            return RedirectToAction("StudentRegistration");

            
        }

        public ActionResult FetchStudent()
        {

            var data = sk.students.ToList();

            return View(data);
        }

        public ActionResult DelStudent(int id)
        {
            var x = sk.students.Find(id);
            sk.students.Remove(x);
            sk.SaveChanges();
            return RedirectToAction("FetchStudent");
        }

        public ActionResult EditStudent(int id)
        {

            return View(sk.students.Find(id));
        }

        [HttpPost]
        public ActionResult EditStudent(Students sp)//here new updated data
        {
            var p = sk.students.Find(sp.sid);

            
            p.sid = sp.sid;
            p.sname = sp.sname;
            p.semail = sp.semail;
            p.sphone = sp.sphone;
            p.sgender = sp.sgender;
            p.sdob = sp.sdob;
            p.scourse = sp.scourse;
            p.saddress = sp.saddress;

            sk.students.AddOrUpdate(p);
            sk.SaveChanges();



            return RedirectToAction("FetchStudent");
        }
    }
}