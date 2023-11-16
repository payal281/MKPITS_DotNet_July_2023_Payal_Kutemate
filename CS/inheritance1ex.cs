using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class person 
    {
        public string name;
       
    }
    //creating a derieved class student
    class student : person
    {
        public int rno;
    }
    class program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.rno = 1;
            s.name = "payal";
            Console.WriteLine("rno: " + s.rno);
            Console.WriteLine("name: " +s.name);
            Console.ReadKey();

        }
    }

}
