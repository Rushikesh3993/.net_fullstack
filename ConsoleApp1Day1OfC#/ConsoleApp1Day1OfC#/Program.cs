//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ConsoleApp1Day1OfC_;
using System;

namespace ConsoleApp1Day1OfC_Sharp
{
    public class Program
    {

        static int y = 100;
        int a = 40;
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World! here your calculation");


            //Operation obj = new Operation();
            //obj.Accept();
            //obj.add();
            //obj.sub();
            //obj.multiply();
            //obj.divide();

            int y = 10;
            y = 20;
            Console.WriteLine("Y is the static variable" +y);
            Console.WriteLine("Y is the static variable" + Program.y);
            Program obj = new Program();
            Console.WriteLine("a is " + obj.a);
            A obj1 = new A();
            obj1.fun1();
            A.fun();

            const string comnayname = "SHIVA CONCEPT Solution";
          
            Console.WriteLine(comnayname);
            

        }
    }
}
