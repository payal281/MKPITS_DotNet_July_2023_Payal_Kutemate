﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter number");
            number = Convert.ToInt32(Console.ReadLine());
            int counter = 2;
            int flag = 0;
            while (counter < number)
            {
                if (number % counter == 0)
                {
                    flag = 1;
                    break;
                }
                counter++;

            }
            if (flag == 0)
            {
                Console.WriteLine("no is prime");
            }
            else
            {
                Console.WriteLine("no is not prime");
            }


            Console.ReadKey();
        }
    }
}
