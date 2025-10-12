using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2Code_first_approach_entity.Models
{
    public class Students
    {
        [Key]
        public int sid { get; set; }

        public String sname { get; set; }
        
        public String semail { get; set; }

        public String sphone { get; set; }

        public String sgender { get; set; }

        public String sdob { get; set; }

        public String scourse { get; set; }

        public String saddress { get; set; }



    }
}