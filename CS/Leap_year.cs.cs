using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("enter year");
            year = Convert.ToInt32(Console.ReadLine());

                if (year % 4 == 0)
                Console.WriteLine("it is a Leap year");
            else
                Console.WriteLine("it is not Leap year");
                Console.ReadKey();

        }
    }
}
