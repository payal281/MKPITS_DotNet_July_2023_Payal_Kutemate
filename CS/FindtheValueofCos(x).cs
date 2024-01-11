/*
 * C# Program to Find the Value of Cos(x)
 */
using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double d = 0; d < 6.0; d += 0.5)
            {
                Console.WriteLine("The cosine of {0} = {1}", d, Math.Cos(d));
                Console.WriteLine("Calculated cosine of {0} = {1}", d, cos(d));
                Console.WriteLine();
            }
            Console.ReadKey(); 
        }
 
        static double cos(double x) 
        {
            double p = x * x; 
            double q = p * p;
            return 1.0 - p / 2 + q / 24 - p * q / 720 + q * q / 40320 
            - p * q * q / 3628800;
        }
    }
}