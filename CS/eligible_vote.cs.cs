using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eligible_vote
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter the number");
            age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
                Console.WriteLine("it is eligible for casting your vote");
            else
                Console.WriteLine("it is not eligible for casting your vote ");
            Console.ReadKey();
        }
    }
}
