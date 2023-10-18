using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print1to5using_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            do
            {
                Console.WriteLine("num0{0}", num);
                num++;
            } while (num <=5);
            Console.ReadKey();
        }
    }
}
