﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        enum grade { a, b, c }

        static void Main(string[] args)
        {
            int g = Convert.ToInt32(grade.b);
            Console.WriteLine("value of  a is " + g);
            Console.ReadLine();
        }
    }
}
