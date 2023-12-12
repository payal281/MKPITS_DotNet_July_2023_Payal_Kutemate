/*
 *  C# Program to Find Roots of a Quadratic Equation
 */
using System;
 
namespace example
{
    class Quadraticroots
    {
        double a, b, c;
 
        public void read()
        {
            Console.WriteLine("\n To find the roots of a quadratic equation of " + 
                              "the form a*x*x + b*x + c = 0");
            Console.Write("\n Enter value for a : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\n Enter value for b : ");
            b = double.Parse(Console.ReadLine());
            Console.Write("\n Enter value for c : ");
            c = double.Parse(Console.ReadLine());
        }
        public void compute()
        {
            int m;
            double r1, r2, d1;
            d1 = b * b - 4 * a * c;
            if (a == 0)
                m = 1;
            else if (d1 > 0)
                m = 2;
            else if (d1 == 0)
                m = 3;
            else
                m = 4;
            switch (m)
            {
                case 1: Console.WriteLine(@"\n Not a Quadratic equation, 
                                          Linear equation");
                    Console.ReadLine();
                    break;
                case 2: Console.WriteLine("\n Roots are Real and Distinct");
                    r1 = (-b + Math.Sqrt(d1)) / (2 * a);
                    r2 = (-b - Math.Sqrt(d1)) / (2 * a);
                    Console.WriteLine("\n First root is {0:#.##}", r1);
                    Console.WriteLine("\n Second root is {0:#.##}", r2);
                    Console.ReadLine();
                    break;
                case 3: Console.WriteLine("\n Roots are Real and Equal");
                    r1 = r2 = (-b) / (2 * a);
                    Console.WriteLine("\n First root is {0:#.##}", r1);
                    Console.WriteLine("\n Second root is {0:#.##}", r2);
                    Console.ReadLine();
                    break;
                case 4: Console.WriteLine("\n Roots are Imaginary");
                    r1 = (-b) / (2 * a);
                    r2 = Math.Sqrt(-d1) / (2 * a);
                    Console.WriteLine("\n First root is {0:#.##} + i {1:#.##}", 
                                       r1, r2);
                    Console.WriteLine("\n Second root is {0:#.##} - i {1:#.##}", 
                                      r1, r2);
                    Console.ReadLine();
                    break;
            }
        }
    }
 
    class Roots
    {
        public static void Main()
        {
            Quadraticroots qr = new Quadraticroots();
            qr.read();
            qr.compute();
        }
    }
}