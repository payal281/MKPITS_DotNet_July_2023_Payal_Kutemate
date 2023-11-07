using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    class calculate
    {
        public void addition (int n1,int n2)
        {
            int  res = n1 + n2;
            Console.WriteLine("addition of 2 int is  "+ res);

        }
        public void addition(float n1,float n2)
        {
            float res = n1 + n2;
            Console.WriteLine("addition of 2 float " + res);

        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            calculate c=new calculate();
            c.addition(1, 2);
            Console.WriteLine("now calling adding of two float nos");
            c.addition(2.3f, 3.3f);
            Console.ReadKey();
        }
    }
}
