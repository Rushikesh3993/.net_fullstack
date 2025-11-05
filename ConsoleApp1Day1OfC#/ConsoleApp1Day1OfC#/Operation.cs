using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day1OfC_Sharp
{
    public class Operation
    {
        int a, b, c;

      public void Accept()
        {
            Console.WriteLine("Enter First Numbre");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt32(Console.ReadLine());
        }
       public void add()
        {
            c = a + b;
            Console.WriteLine(c);
        }

        public void sub()
        {
            c = a - b;
            Console.WriteLine(c);
        }

        public void multiply()
        {
            c = a * b;
            Console.WriteLine(c);

        }

        public void divide()
        {
            c = a / b;
            Console.WriteLine(c);
        }
    }
}
