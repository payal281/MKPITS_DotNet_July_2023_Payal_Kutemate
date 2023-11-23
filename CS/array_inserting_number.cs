using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ConsoleApp59
   
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar=new ArrayList();
            ar.Add(22);
            ar.Add(25);
            ar.Add(23);
            //displaying values of arraylist
            Console.WriteLine("array list collection without sorting");
            foreach(int obje in ar)
            {
                Console.WriteLine("student rno" + obje);

            }
            ar.Insert(2, 17);
            Console.WriteLine("array list collection after adding element at 2position");
        foreach(int  obje in ar)
            {
                Console.WriteLine("student rno" + obje);
            }
            Console.ReadKey();
        }
    }
}
