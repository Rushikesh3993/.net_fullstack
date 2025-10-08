using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2_data_anotation.Models
{

    public class Student
    {
        [Required(ErrorMessage ="Please Enter Id")]
        [Display(Name ="student_id")]
        public int sid { get; set; }

        [Required(ErrorMessage ="Please Enter Name")]
        public String sname { get; set; }

        [Required(ErrorMessage ="Please Enter Email")]
        //[RegularExpression("/^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$/", ErrorMessage ="Plase Enter the valid Email")]

        [EmailAddress(ErrorMessage = "Plase Enter the valid Email")]
        public String semail { get; set; }

        [Required(ErrorMessage ="Please Enter Age")]
        [Range(18,30,ErrorMessage ="Enter Age Between 18 to 30")]
        public int sage { get; set; }

        [Required(ErrorMessage ="Please Enter Password")]
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,}",ErrorMessage = "Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters")]
        [Compare("scpass",ErrorMessage ="Pass and Confirm pass is not Matched")]

        public String spass { get; set; }

        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,}", ErrorMessage = "Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters")]
        [DataType(DataType.Password)]

        public String scpass { get; set; }

        [Required(ErrorMessage ="Please Enter Date")]
        [DataType(DataType.Date)]
        //[DataType(DataType.CreditCard)]
        //[DataType(DataType.PhoneNumber)]


        public String sdate { get; set; }
    }
}