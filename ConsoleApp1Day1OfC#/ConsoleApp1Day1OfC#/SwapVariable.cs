using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day1OfC_
{
    internal class SwapVariable
    {

        public static void Swap( ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }
        public static void Main(String[] args)
        {
            //int a = 10;
            //int b = 20;

            //int temp = a;
            //a = b;
            //b = temp;
            //Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);

            int a = 10;
            int b = 20;

            Console.WriteLine("before Swap: " +a + " "  +b);
            Swap(ref a, ref b);
            //Console.WriteLine("after Swap: : " +a + " " +b);
            Console.WriteLine($"after Swap: a = {a}, b = {b}");


        }
    }
}
