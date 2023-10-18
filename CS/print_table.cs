using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_table1to3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag;
            Console.WriteLine("enter limit");
            flag = Convert.ToInt32(Console.ReadLine());
            int Counter = 1;
            int Counter1 = 1;
            while(Counter<=10)
            {
                Counter1 = 1;
                while (Counter1 <= flag)
                {
                    Console.Write("{0}*{1}={2}",Counter, Counter1, (Counter1 * Counter));
                    Console.Write("\t");
                    Counter1++;
                }
                Counter++;
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
