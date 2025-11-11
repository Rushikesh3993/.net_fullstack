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

            //string[] city = new string[8];

            //Console.WriteLine("Enter Your city name");
            //for(int i =1;i <= 8; i++)
            //{
            //    city[i]  = Console.ReadLine();
            //}

            //int[,,] a = new int[3,2,2] this 3,2,2 is index 
            int[,,] a = 
            {
                {
                    {1,2},
                    {3,4}

                },

                {
                    {5,6},
                    {7,8}
                },

                {
                     {9,10},
                    {11,12}
                }

            };
                                      //oth index means new int[3]
            for(int i = 0; i < a.GetLength(0); i++)
            {                        //1th index means new int[2]
                for (int j = 0;  j < a.GetLength(1); j++)
                {                    //2th index means new int[3]
                    for (int k = 0; k < a.GetLength(2); k++)
                    {
                        Console.Write(a[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
