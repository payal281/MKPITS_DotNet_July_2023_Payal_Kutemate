using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    class Company
    {
        public string Name = "mkcl";
        public void display()
        {
            Console.WriteLine("Compnay name:" + Name);
        }
    }
    class franchise : Company
    {
        public string name = "mkpits";
        public void display()
        {
            base.display();
            Console.WriteLine("franchise name: " + name);
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            franchise f = new franchise();
            f.display();
            Console.ReadKey();
        }
    }
}