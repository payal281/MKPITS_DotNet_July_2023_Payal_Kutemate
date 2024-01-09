using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_withstring
{



    internal class Program
    {
        enum category { student,it_professional};

        static void Main(string[] args)
        {
            int c= Convert.ToInt32(category.student);
            if (c == 0)
                Console.WriteLine("category is student");
            else if (c == 1)
                Console.WriteLine("category is It professional");
            Console.ReadLine();  
        }
    }
}
