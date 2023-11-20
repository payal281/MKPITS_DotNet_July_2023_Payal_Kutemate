using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    abstract class shape
    {
        public abstract void draw();   
    }
    class rectangle : shape
    {
        public override void draw()
        {
            Console.WriteLine("code to draw rectangle");  
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            shape shape = new rectangle();
            shape.draw();
            Console.ReadLine();
        }
        
    }
}
