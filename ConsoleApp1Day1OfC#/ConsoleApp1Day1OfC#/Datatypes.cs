using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day1OfC_Sharp //collection of classes
{
    internal class Datatypes //internal is access modifier
    {
      public  static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("Ibterger value is : " +a);
            byte b = 3;
            Console.WriteLine("byte value is : " +b);
            float c = 5.5f;
            Console.WriteLine("float value is : " +c);
            short d = 4;
            Console.WriteLine("short value is : " +d);
            //char e = 'a';
            char e = '@';
            Console.WriteLine("charater value is : "+e);
            double f = 44.333;
            Console.WriteLine("Double value is : " +f);
            bool g = true;
            if (g)
            {
                Console.WriteLine("Boolean is true");
            }
            else
            {
                Console.WriteLine("Boolean is flase");

            }
            Console.WriteLine("boolean value is : " + g);
            //decimal h = (decimal)128.56;
            decimal h = 128.56m;
            Console.WriteLine("decimal value is : " +h);
            string i = "Rushikesh Mote";
            Console.WriteLine(i);




        }
    }
}
