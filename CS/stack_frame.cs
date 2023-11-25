using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push("A");
            st.Push("M");
            st.Push("G");
            st.Push("W");
            Console.WriteLine("current stack:");
            foreach(char c in st)
            {
                Console.Write(c + "");
            }
            Console.WriteLine();

            st.Push("V");
            st.Push("H");
            Console.WriteLine("the poppable vale in stack:{0}", st.Peek());
            Console.WriteLine("current stack");
            foreach(char c in st)
            {
                Console.WriteLine(c + "");
            }
            Console.WriteLine();
            Console.WriteLine("Removing values");
            st.Pop();
            st.Pop();
            st.Pop();
            Console.WriteLine("Current stack:");
            foreach (char c in st) 
            Console.Write(c + " ");
            Console.ReadKey();


        }
    }
}
