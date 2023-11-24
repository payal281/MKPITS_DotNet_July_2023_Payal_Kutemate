using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl= new SortedList();
            sl.Add("001", "payal");
            sl.Add("002", "partu");
            sl.Add("003", "neha");
            sl.Add("004", "snehal");
            sl.Add("005", "prachi");
            sl.Add("006", "prajval");
            sl.Add("007", "nikita");

            if (sl.ContainsValue("pranita"))
            {
                Console.WriteLine("this student name already in the list");

            }
            else
            {
                sl.Add("008", "vidhi");
            }
            //get the collection of key
            ICollection key = sl.Keys;
            foreach(string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }
            Console.ReadKey();

        }
    }
}
