using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization;

namespace ConsoleApp55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar=new  ArrayList();
            ar.Add("payal");
            ar.Add("nikita");
            ar.Add("rita");
            ar.Add("rutuja");
            foreach(object obj in ar)
            {
                Console.WriteLine("name: " + obj);
            }
            Console.ReadLine();
        }
    }
}
