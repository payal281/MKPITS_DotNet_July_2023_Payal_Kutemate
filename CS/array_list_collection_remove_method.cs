using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar= new ArrayList();
            ar.Add(12);
            ar.Add(13);
            ar.Add(14);
            //displaying value of arraylist
            Console.WriteLine("array list collection without sorting");
            foreach (int obj in ar)
            {
                Console.WriteLine("student rno " + obj);            }
            ar.Remove(13);
            Console.WriteLine("array loist collection after removing 13");
            foreach (int obj in ar)
            {
                Console.WriteLine("student rno " + obj);

            }
            ar.Remove(1);
            Console.WriteLine("array list collection after removing 1");
                foreach(int obj in ar)
            {
                Console.WriteLine("student rno"+obj);
            }
            Console.ReadKey();
        }
    }
}
