using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day1OfC_Sharp
{
    public  class Calculator
    {
        public static void Main(string[] args)
        {
            

            Console.WriteLine("choose Operator :");
            Console.WriteLine("1.Addition ");
            Console.WriteLine("2.Subtraction ");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");

            int ch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your first Number :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number :");
            int b = Convert.ToInt32(Console.ReadLine());

            int result;

            switch (ch)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine("Addition is : " + result);
                    break;

                case 2:
                    result = a - b;
                    Console.WriteLine("Substraction is : " + result);
                    break;

                case 3:
                    result = a * b;
                    Console.WriteLine("Multiplication is : " + result);
                    break;

                case 4: 
                    result = a / b;
                    Console.WriteLine("Division is : " + result);
                    break;
                
                default:
                    Console.WriteLine("Invalid Operation");
                    break;



            }

            Console.ReadLine();// To keep the console window open



        }
    }
}
