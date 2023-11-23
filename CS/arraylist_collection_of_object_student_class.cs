using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp61
{
    class student
    {
        public int rno;
        public String name;
        public student(int rno, string name)
        {
            this.rno = rno;
            this.name = name;
        }
        class program
        {
            static void Main(string[] args)
            {
                student s1 = new student(12, "amit");
                student s2 = new student(13, "raj");
                student s3 = new student(14, "raman");
                ArrayList a1= new ArrayList();
                a1.Add(s1);
                a1.Add(s2); 
                a1.Add(s3);
                //displaying the values of student
                foreach(student s in a1)
                {
                    Console.WriteLine("rno:" + s.rno);
                    Console.WriteLine("name: " + s.name);
                }
                Console.ReadKey();

            }
        }
    }
}