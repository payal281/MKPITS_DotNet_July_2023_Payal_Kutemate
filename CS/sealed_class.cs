using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    abstract class person
    {
        public string name;
    }
    class student : person
    {
        public int rno;
    }
    sealed class parttimestudent:student
    {
        public int hours;
    }
    internal class program
    {
        static void Main(string[] args)
        {
            parttimestudent p = new parttimestudent();
            p.rno = 22;
            p.name = "ravi";
            Console.WriteLine("rno:"+ p.rno);
            Console.WriteLine("name:"+p.name);
            Console.WriteLine("hours:"+ p.hours);
            Console.ReadKey();

        }
    }
}
