﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_table_multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, counter = 1, result = 0;
            Console.WriteLine("Enter num: ");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                result = num * counter;
                Console.WriteLine("{0} X {1} = {2}", num, counter, result);
                counter++;
            } while (counter <= 10);
            Console.ReadKey();
        }
    }
}
