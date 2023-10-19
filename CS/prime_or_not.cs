using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cnt;
            int rem;
            Console.WriteLine("enter num");
            num = Convert.ToInt32(Console.ReadLine());
            for(cnt=2; 
                cnt<num; cnt++)
            {
                rem = num % cnt;
                if (rem == 0)
                {
                    Console.WriteLine("not a prime number");
                    break;
                    cnt = 1;

                }
            }
            
            if(num == cnt)
            {
                Console.WriteLine("it is a prime number");
            }
            Console.ReadKey();

        }
    }
}
