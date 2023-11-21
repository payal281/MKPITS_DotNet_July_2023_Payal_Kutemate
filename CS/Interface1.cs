using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    interface shape
    {
        void draw();
        
    }
    class rectangle : shape
    {
        public void draw()
        {
            Console.WriteLine(":draw method of rectangle class: ");
        }
    }
    class circle:shape
    {
        public void draw()
        { 
            Console.WriteLine(":draw method of circle class: ");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            shape shape = new rectangle();
            shape.draw();
            shape=new circle();
            shape.draw();
            Console.ReadKey();
        }
    }

}
