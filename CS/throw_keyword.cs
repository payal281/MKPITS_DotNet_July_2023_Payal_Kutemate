using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            try
            {
                Console.WriteLine("enter age");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                {
                    throw new Exception("age should be greater or equal to ");

                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("enter age 18 or greater than 18");
                age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("finally block is executing");
                Console.WriteLine("Age = " + age);

            }

            Console.WriteLine("bye");
            Console.ReadKey();
        }

    }


}
 
