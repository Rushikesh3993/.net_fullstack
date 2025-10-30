using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1API.Models
{
    public class Customer
    {
        [Key]

        public int cid { get; set; }

        public string cname { get; set; }

        public string cemail { get; set; }

        public string cpass { get; set; }
    }
}