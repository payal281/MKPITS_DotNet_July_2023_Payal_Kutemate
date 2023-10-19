using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_table1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cnt;
            int res = 0;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for(cnt=1;cnt<= num; cnt++)
            {
                res = num * cnt;
                Console.WriteLine("{0}*{1}={2}", num, cnt, res);
            }
            Console.ReadKey();
        }
    }
}
