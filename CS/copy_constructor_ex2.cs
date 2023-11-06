using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_constructor_ex2
{
    class employee
    {
        private string name;
        private int age;
        public employee(employee emp)//declaring copy constructor
        {
            name = emp.name;
            age = emp.age;

        }
        public employee(string name, int age)//Instance constructor.
        {
            this.name = name;
            this.age = age;
        }
        public string Details//get details of employee
        {
            get
            {
                return "The age of " + name + " is " + age.ToString();

            }

        }
    }
    class empdetail
    {
        static void Main()
        {
            employee emp1 = new employee("payal", 23);//create a new employee object
            employee emp2 = new employee(emp1);//here is emp1 details is copied to emp2
            Console.WriteLine(emp2.Details);
            Console.ReadLine();

        }
    }
}
