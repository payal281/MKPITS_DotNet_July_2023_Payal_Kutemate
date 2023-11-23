using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(556);
            ar.Add(35);
            ar.Add(22);
            //display value of arraylist
            Console.WriteLine("array list collection without soting");
            foreach(int obj in ar)
            {
                Console.WriteLine("student rno "+obj);

            }
            //sorting 
            ar.Sort();
            Console.WriteLine("array list collection with soeting");
            foreach(int obj in ar)
            {
                Console.WriteLine("student rno " + obj);
            }
            Console.ReadLine();
        }
    }
}
