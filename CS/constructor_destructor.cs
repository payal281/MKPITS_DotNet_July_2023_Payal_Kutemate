using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_destructor
{
    class Employee
    {
        //creating a constructor
        public Employee()
        {
            Console.WriteLine("constructor called");

            
        }
        ~Employee()
        {
            Console.WriteLine("destructor called");
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.ReadKey();
       
            Employee emp1 = new Employee();
            Console.ReadKey();

        }
    }

}
