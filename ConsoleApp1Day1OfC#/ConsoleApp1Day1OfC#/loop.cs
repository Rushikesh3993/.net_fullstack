using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day1OfC_
{
    internal class loop
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The End point number");
            int e = Convert.ToInt32(Console.ReadLine());

            while(n <= e)
            {
                Console.WriteLine(n);
                n++;
            }
        }
    }
}
