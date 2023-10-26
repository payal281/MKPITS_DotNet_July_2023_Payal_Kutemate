using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_number_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            for (int cnt = 0; cnt < 3; cnt++)
            {
                Console.WriteLine("enter number");
                num[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            for (int cnt = 0; cnt < 3; cnt++)
            {
                Console.WriteLine("num[{0}]= {1}", cnt, num[cnt]);

            }

            Console.ReadKey();
        }
    }
}
