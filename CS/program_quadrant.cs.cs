using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_quadrant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter x value");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y value");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("The coordinate point" + (x, y) + "lies in the 1st quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The coordinate point" + (x, y) + "lies in the 2st quadrant");

            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The coordinate point " + (x, y) + "lies in the 3rd quadrant");

            }
            else if(x<0 && y>0)
            {
                Console.WriteLine("The coordinate point " + (x, y) + "lies in the 4th quadrant");

            }
            {
                Console.ReadKey();
            }        
        }
    }
}7