using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
   public class person
    {
        public string name;
        public string address;

    }
    public class employee : person
    {
        public int empno;
        public string name;
        public int salary;
        public string designation;
        public string address;

    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            employee e1 = new employee();
            e1.empno = 1;
            e1.salary = 6655;
            e1.designation = "clerk";
            e1.name = "payal";
            e1.address = "pune";

            Console.WriteLine("empno:" + e1.empno);
            Console.WriteLine("salary:" + e1.salary);
            Console.WriteLine("designation:" + e1.designation);
            Console.WriteLine("name:" + e1.name);
            Console.WriteLine("address:" + e1.address);
            Console.ReadKey();


        }
    }
}
    
   