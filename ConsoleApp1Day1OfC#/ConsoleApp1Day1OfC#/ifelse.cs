using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day1OfC_
{
    internal class ifelse
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Conditional Statements");
            Console.WriteLine("Enter Your First Number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your second Number");
            int b = Convert.ToInt32(Console.ReadLine());

            if(a == b)
            {
                Console.WriteLine("This number is equal to each other");
            }
            else if(a > b)
            {
                Console.WriteLine("First number is greater than seconnd");
            }
            else if(b > a)
            {
                Console.WriteLine("Second Number is grater than first");
            }
            else if(a < b)
            {
                Console.WriteLine(" first number is smaller than second");
            }
            else if (b < a)
            {
                Console.WriteLine(" second number is smaller than first");
            }
            else
            {
                Console.WriteLine("invalid integers");
            }
        }
    }
}
