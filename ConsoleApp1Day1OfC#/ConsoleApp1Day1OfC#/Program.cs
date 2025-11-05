//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace ConsoleApp1Day1OfC_Sharp
{
  public class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! here your calculation");
          
           
           Operation obj = new Operation();
            obj.Accept();
            obj.add();
            obj.sub();
            obj.multiply();
            obj.divide();

        }
    }
}
