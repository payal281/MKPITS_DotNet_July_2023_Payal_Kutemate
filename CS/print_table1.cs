using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sn = 1, en = 2;
            int res1, res2;
            int Counter = 1;
            while (Counter <= 10)

            {
                res1 = sn * Counter;
                res2 = en * Counter;
                Console.Write("{0}*{1}={2}", sn, Counter, res1);
                Console.Write("\t");
                Console.Write("{0}*{1}={2}", en, Counter, res2);
                Counter++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
