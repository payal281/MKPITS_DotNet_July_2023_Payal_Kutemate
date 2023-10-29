using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stores_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int cnt = 0; cnt < numbers.Length; cnt++)
            {
                Console.Write("Enter a number:");
                string input = Console.ReadLine();
                numbers[cnt] = Convert.ToInt32(input);
            }
            Console.WriteLine("The number you entered are:");
            for(int cnt=0; cnt < numbers.Length; cnt++)
            {
                Console.Write(numbers[cnt] +"\t");
            }
            Console.ReadKey();
        }
    }
}
