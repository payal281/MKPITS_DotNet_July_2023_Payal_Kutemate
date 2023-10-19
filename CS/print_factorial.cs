using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
                for(int Count=num; Count>0; Count --)
            {
                fact = fact * Count;
            }
            Console.WriteLine("fact= " + fact);
            Console.ReadKey();
        }
    }
}
