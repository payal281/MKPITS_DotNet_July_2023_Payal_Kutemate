using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
     class Program
    {
        static void Main(string[] args)
        {
            int height;
            Console.WriteLine("enter number");
            height = Convert.ToInt32(Console.ReadLine());

            if (height < 150)
                Console.WriteLine("it is dwarf");
            else
                Console.WriteLine("it is not dwarf");
            Console.ReadKey();

        }
    }
}
