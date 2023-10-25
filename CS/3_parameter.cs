using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_parameter
{
    internal class Program
    {
        static int calculate(int num1, int num2, char op) //method with 3 integer parameter
        {
            int res = 0;
            if (op == '+')
                res = num1 + num2;
            else if (op == '-')
                res = num1 - num2;
            else if (op == '*')
                res = num1 * num2;
            else
                Console.WriteLine("invalid operator");
            return res;
        }
        static void Main(string[] args)
        {
            int number1, number2;
            char oper;
            Console.WriteLine("enter number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter + - *");
            oper = Convert.ToChar(Console.ReadLine());
            int result = calculate(number1, number2, oper);
            Console.WriteLine("result  " + result);


            Console.ReadKey();

        }
    }
}