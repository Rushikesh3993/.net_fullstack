using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day1OfC_
{
    internal class DateDiff
    {
        public static void Main(string[] args)
        {
            string date1 = "12052020";
            string date2 = "13062021";

            int d1 = Convert.ToInt32(date1);
            int d2 = Convert.ToInt32(date2);

            int y1 = d1 % 10000;
            int y2 = d2 % 10000;
            Console.WriteLine("difference of dates in years: " + (y2 - y1));
        }
    }
}
