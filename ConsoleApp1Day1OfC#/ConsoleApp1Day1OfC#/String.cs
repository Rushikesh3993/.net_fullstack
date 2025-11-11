using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day1OfC_
{
    internal class String
    {
        public static void Main(string[] args)
        {
            string str = "John ";

            string name = string.Concat(str, "Doe");
            Console.WriteLine(name);
            if (str.Contains("Rushi"))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            
            string a = "Hello ";
            string b = "World";

            if(a == b)
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("Not Equals");
            }

            string c = "abhi";
            string d = "abhi";

            if (c.Equals(d))
            {
                Console.WriteLine("This is Equals");
            }
            else
            {
                Console.WriteLine("This is Not Equals");
            }

        }
    }
}
