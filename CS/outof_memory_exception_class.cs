using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp80
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "payal";
            string subject = "mathematics";
            StringBuilder sb = new StringBuilder( name.Length,name.Length);
            try
            {
                sb.Append(subject);
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.ToString());   
            }
            Console.WriteLine("bye");

        }
    }
}
