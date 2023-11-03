using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_ass2_class_employee
{
    class employee
    {
        int empno;
        string empname, designation;
        int salary;
        //creating a constructor with no parameters
        public employee()
        {
            empno = 1;
            empname = "payal";
            designation = "clerk";
            salary = 30000;

        }
        public void display()
        {
            Console.WriteLine("empno= " + empno);
            Console.WriteLine("empname= " + empname);
            Console.WriteLine("designation= " + designation);
            Console.WriteLine("salary= " + salary);


        }

    }
    class program
    {
        static void Main(string[] args)
        {


            employee employee = new employee(); //this will call constructor automaticallty
            employee.display();
            Console.ReadLine();
        }
                                         
        

    }
}
