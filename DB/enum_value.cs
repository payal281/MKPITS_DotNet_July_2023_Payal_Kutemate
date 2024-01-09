using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_values
{
    internal class Program
    {
        enum grade { a=60,b=50,c=100 }
        static void Main(string[] args)
        {
            int g = Convert.ToInt32(grade.b);
            Console.WriteLine("value of b is " + g);
            Console.ReadLine();
        }
    }
}
