﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp81
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arr = new int[3];
            arr[0] = 11;
            arr[1] = 12;
            arr[2] = 13

            try
            {
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine("arr =" + arr[i]);
                }
            }
            catch(IndexOutOfRangeException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.WriteLine("finally block is executing");
            }
            Console.WriteLine("bye");

        }
    }
}
