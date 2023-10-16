using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_to_readvalue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.WriteLine("enter number: ");
            m = Convert.ToInt32(Console.ReadLine());

            if (m > 0)
                Console.WriteLine("n=1");
            else
                Console.WriteLine("n=-1");
            Console.ReadKey();


        }
    }
}
