using System;
namespace consoleApp1
{
    class Class1
    {
        struct student
        {
            public int rno;
            public string name;
            public string course;

        }
        public static void Main()
        {
            student s1;
            s1.rno = 20;
            s1.name = "payal";
            s1.course = "dotnet";

            Console.WriteLine("rno " + s1.rno);
            Console.WriteLine("name " + s1.name);
            Console.WriteLine("course " + s1.course);

        }
    }
}

