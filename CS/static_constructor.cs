using staticConstractor;
using System;
namespace staticConstractor
{
    public class employee
    {
        static employee() // Static constructor
                          //decleration
        {
            Console.WriteLine("hi 1");

            Console.WriteLine("The static constructor ");
            Console.WriteLine("\nibbiuniujniunhiugyugyugybiuhiuhiuhiuhujiujuihuhiu ");

        } 
        
    
    public static void Salary()
    {
           
            Console.WriteLine();
           Console.WriteLine("hi 2");
            Console.WriteLine("The Salary method");
    }
}
class details
{
    static void Main()
    {
            employee.Salary();
            
        Console.WriteLine();
            employee.Salary();
            employee.Salary();
            employee.Salary();


            Console.ReadLine();
    }
}
}

