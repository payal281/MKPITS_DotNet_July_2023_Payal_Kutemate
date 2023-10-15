using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter num :");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine(+num + " " + " it is even ");
            else
                Console.WriteLine(+num + " " + " it is odd ");
            Console.ReadKey();

        }
    }
}
