﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_method
{
    class book
    {
        static string title;
        static book()
        {
            Console.WriteLine("static constructor called");
            title = "mkpits";

        }
        public static void display()
        {
            Console.WriteLine("title :" + title);

        }

    }
    class program
    {
        static void Main(string[] args)
        {
            book.display();
            Console.ReadKey();
        }
    }
}
