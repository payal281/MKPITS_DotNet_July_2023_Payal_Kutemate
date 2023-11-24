using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics.Eventing.Reader;


namespace ConsoleApp65
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("001", "prachi");
            ht.Add("002", "pratu");
            ht.Add("003", "neha");
            ht.Add("004", "snehal");
            ht.Add("005", "vidhi");
            ht.Add("006", "priti");
            ht.Add("007", "nikita");
            if (ht.ContainsValue("payal"))
            {
                Console.WriteLine("The student already in the list");
            }
            else
            {
                ht.Add("008", "payal");
            }
            //get collection of the keys.\
            ICollection key=ht.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k + ":" + ht[k]);

            }
            Console.ReadKey();
        

        }
    }
}

