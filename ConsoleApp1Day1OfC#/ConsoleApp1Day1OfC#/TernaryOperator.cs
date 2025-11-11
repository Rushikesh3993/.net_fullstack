using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day1OfC_
{
    internal class TernaryOperator
    {
        public static void Main(string[] args)
        {
            //int a = 20; int b = 10;
            //int res = ((a > b) ? a: b);
            //Console.WriteLine("Result" + res);


            Console.WriteLine("Excuting Statment1");
            Console.WriteLine("Executing Statement2");
            goto statement5;
            Console.WriteLine("Excuting Statment3");
            Console.WriteLine("Executing Statement4");
            statement5:
            Console.WriteLine("Excuting Statement5");
            Console.WriteLine("Executing Statement6");
        }
    }
}
