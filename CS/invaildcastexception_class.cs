using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp79
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("payal");
            sb.AppendLine("pratu");
            Console.WriteLine("sb=" + sb.ToString());
            object obj = sb;
            Console.WriteLine("obj="+obj.ToString());

            try
            {
                System.IO.StreamReader sr = (System.IO.StreamReader)obj;
            }
            catch(NullReferenceException ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("bye");
            }
        }
    }
}
