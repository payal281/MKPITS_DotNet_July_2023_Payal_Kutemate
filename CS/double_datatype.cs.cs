using System;
namespace ConsoleApp1
{
    class Class1
    {

        public static void Main()
        {
            double b = 123456.1234567890123; //signed
            Console.WriteLine(" value " + b);
            Console.WriteLine("enter value ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("value = " + b);



            Console.ReadLine();
            Console.ReadKey();
        }
    }
}

