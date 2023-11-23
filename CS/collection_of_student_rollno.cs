using System;

using System.Collections;

namespace ConsoleApp57

{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(22);
            ar.Add(23);
            ar.Add(24);
            ar.Add(25);
            foreach (int obj in ar)
            {
                Console.WriteLine("student rno: " + obj);
            }
            Console.ReadLine();



        }
    }
}
