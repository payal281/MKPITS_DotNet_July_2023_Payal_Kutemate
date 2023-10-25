using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accepting_value_from_user
{
    internal class Program
    {
        static void factorial(int num) //method with one integer parameter
        {
            int fact = 1;
            while(num>0)
            {
                fact = fact * num;
                num--;

            }
            Console.WriteLine("fact" + fact);
        }

        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter number: ");
            number = Convert.ToInt32(Console.ReadLine());
            factorial(number);
            Console.ReadKey();
        }
    }
}
