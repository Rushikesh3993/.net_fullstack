using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day1OfC_
{
    internal class sumOfdigit
    {
        public static void Main(string[] args)
        {
            string date1 = "12052020";
            int d1 = Convert.ToInt32(date1);
            int sum = 0;

            while(d1 != 0)
            {
                int ldg = d1 % 10;
                d1 = d1 / 10;
                sum = sum + ldg;

            }
            Console.WriteLine("sum of digits: " + sum);
        }
    }
}
