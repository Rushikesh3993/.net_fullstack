using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day1OfC_
{
    internal class RegistrationFrom
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("== Facebook Registration From ==");
            Console.WriteLine("It's quick and easy\n");

            Console.Write("Enter First Name : ");
            string fs = Console.ReadLine();

            Console.Write("Enter Last Name : ");
            string ls = Console.ReadLine();

            Console.WriteLine("Enter Date of Birth (DD/MM/YYYY) : ");
            string date = Console.ReadLine();

            Console.WriteLine("Gender (Male/Female/Other) : ");
            string gender = Console.ReadLine();

            Console.WriteLine("Email address : ");
            string email = Console.ReadLine();

            Console.WriteLine("New Password : ");
            string password = Console.ReadLine();

            Console.WriteLine("You have successfully registered on Facebook.");
            Console.WriteLine("Name: " + fs + " " + ls);
            Console.WriteLine("Date of Birth: " + date);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Email: " + email);

            Console.WriteLine("Thank You for Registration " + fs + " " + ls);
            Console.ReadLine(); 

        }
    }
}
