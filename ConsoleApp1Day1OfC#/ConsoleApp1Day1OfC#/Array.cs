using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day1OfC_
{
    internal class Array
    {
        public static void Main(string[] args)
        {
            //int[] a = { 10, 20, 30, 40, 50, };

            //for(int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            //string[] arr = { "Satara", "Pune", "Karad", "Kholapur", "Mumbai", "Saswad", "Ahmadnagar", "Raigad" };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            string[] city = new string[8];

            Console.WriteLine("Enter Your city name");
            for(int i =1;i <= 8; i++)
            {
                city[i]  = Console.ReadLine();
            }
        }
    }
}
