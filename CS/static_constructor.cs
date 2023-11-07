using staticConstractor;
using System;
namespace staticConstractor
{
    public class employee
    {
        static employee() 
                          
        { 

            Console.WriteLine("The static constructor ");

        } 
        
    
    public static void Salary()
    {
           Console.WriteLine();
           Console.WriteLine("The Salary method");
    }
}
class details
{
    static void Main()
    {

            employee.Salary();
            Console.ReadLine();
    }
}
}

