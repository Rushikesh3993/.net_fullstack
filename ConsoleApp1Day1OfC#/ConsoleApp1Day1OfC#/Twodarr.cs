using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day1OfC_
{
    internal class Twodarr
    {
        public static void Main(string[] args)
        {
            //int[,] a = { { 10, 20, 30 }, { 30, 40 , 30} };

            //for(int i = 0; i < a.GetLength(0); i++)
            //{
            //    for(int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.Write(a[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            string[,] a = { {"1.", "Rushi", "Mote" }, { "2.", "Raghav", "Pai" } };
            Console.WriteLine("Id  Fname  lname");

            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
