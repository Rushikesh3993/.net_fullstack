using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day1OfC_
{
    internal class nestedifelse
    {
        public static void Main(string[] args)
        {
            //int raju = 75, sanju = 90, mukesh = 20;

            //if (raju > sanju)
            //{
            //    Console.WriteLine("Raju ag is grater than sanju");
            //}
            //else if (sanju > mukesh)
            //{
            //    Console.WriteLine("Sanju age is grater than mukesh");
            //}
            //else
            //{
            //    Console.WriteLine("mukesh age is greater than all");
            //}

            Console.WriteLine("Voting application");
            int age = 19;
            bool is_voting = true;

            if(age > 18)
            {
                if (is_voting == true)
                {
                    Console.WriteLine("Your are Eligible for voting");
                }
                else
                {
                    Console.WriteLine("You Are not eligible for voting");
                }
            }
            else
            {
                Console.WriteLine("INvalid Age");
            }
        }
    }
}
