using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("A");
            q.Enqueue("M");
            q.Enqueue("G");
            q.Enqueue("W");
            Console.WriteLine("Current queue:");
            foreach(char c in q) Console.Write(c+"");

            Console.WriteLine();
            q.Enqueue("V");
            q.Enqueue("H");
            Console.WriteLine("current queue:");
            foreach(char c in q) Console.Write(c+"");

            Console.WriteLine();
            Console.WriteLine("removing same value");
            char ch=(char)q.Dequeue();
            Console.WriteLine("The removed value:{0}", ch);
            ch=(char)q.Dequeue();
            Console.WriteLine("The removed value:{0}", ch);
            Console.ReadKey();
           
        }
    }
}
