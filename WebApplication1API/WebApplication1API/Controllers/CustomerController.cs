using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1API.Models;

namespace WebApplication1API.Controllers
{
    [RoutePrefix("api/Customer")]
    public class CustomerController : ApiController
    {

        
        //[HttpGet]
        //[Route("display")]

        //public String display()
        //{
        //    return "My Name is : Rushikesh Mote";
        //}

        //[HttpGet]
        //[Route("on")]

        //public String on(int id)
        //{
        //    return "Id is " + id;
        //}

        //[HttpGet]
        //[Route("one")]

        //public int[] one() 
        //{
        //    int[] a = { 10, 20, 30, 40, 50 };
        //    return a;
        //}

        CustomerContext c1 = new CustomerContext();


        // Save Customer Information // 
        [HttpPost]
        public String one(Customer cr)
        {
            c1.Customer.Add(cr);
            c1.SaveChanges();
            return "Registration Successfull!";
        }

        // Fetch All The Customer
        [HttpGet]
        public List<Customer> two()
        {
            var x = c1.Customer.ToList();
            return x;
        }



        // Fetch Customer Info With Given Customer ID
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult three(int id)
        {
            Customer ck = c1.Customer.Find(id);

            if (ck != null)
            {
                return Ok(ck);
            }

            return NotFound();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult Four(int id)
        {
            var x = c1.Customer.Find(id);
            if (x != null)
            {
                c1.Customer.Remove(x);
                c1.SaveChanges();
                return Ok("Record Deleted");
            }
            return NotFound();
        }


       [HttpPut]
       [Route("{id:int}")]

        public IHttpActionResult five(int id,Customer cp)
        {
            var y = c1.Customer.Find(id);
            if (y == null)
            {
                return NotFound();
            }
            
            y.cname = cp.cname;
            y.cemail = cp.cemail;
            y.cpass = cp.cpass;

            c1.SaveChanges();
            return  Ok("record Updated");
        }


        
    }
}

 
