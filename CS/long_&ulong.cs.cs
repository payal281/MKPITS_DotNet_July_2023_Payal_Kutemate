using System;
namespace ConsoleApp1
{
    class Class1
    {

        public static void Main()
        {
            long b = -25890222888L; //signed
            Console.WriteLine(" value " + b);
            Console.WriteLine("enter ");
            b = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("value = " + b);
            //for negative as well as positive no.
            ulong b1 = 2389000L; //unsigned 
            Console.WriteLine("value " + b1);
            Console.WriteLine("enter ");
            b1 = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("value = " + b1);


            Console.ReadLine();
            Console.ReadKey();
        }
    }
}

