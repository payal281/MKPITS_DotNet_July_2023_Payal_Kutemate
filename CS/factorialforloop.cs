﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("enter number = ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int counter = num; counter > 0; counter--)
            {
                fact = fact * counter;
            }
            Console.WriteLine("factorial = " + fact);
            Console.ReadKey();
        }
    }
}
