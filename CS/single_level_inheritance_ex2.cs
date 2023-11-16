using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
     class employee
    {
        protected int salary;
    }
    //creating a derieved class programmer 
    class programmer :employee
    {
        int bouns;
        public void getdata(int salary, int bouns)
        {
            this.salary = salary;
            this .bouns = bouns;
         
        }
        public void displaydata()
        {
            Console.WriteLine("salary " + salary);
            Console.WriteLine("bouns " + bouns);

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            programmer p= new programmer();
            p.getdata(23000, 5000);
            p.displaydata();
            Console.ReadKey();
        }
    }
}
