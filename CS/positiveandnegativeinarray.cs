/*
 * C# Program to Negate the Positive Elements of Array
 */
using System;
using System.Collections.Generic;
using System.Text;
namespace program
{
    class negate
    {
        public static void Main()
        {
            int[] a = new int[10];
            Console.WriteLine("Enter 5 Elements : ");
            for (int i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt16(Console.ReadLine());
                if (a[i] > 0)
                    a[i] = -a[i];
            }
            Console.WriteLine("Elements:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}