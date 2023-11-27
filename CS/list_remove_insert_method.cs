using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> langs = new List<string>();
            langs.Add("java");
            langs.Add("c");
            langs.Add("c++");
            langs.Add("c#");
            langs.Add("Ruby");
            langs.Add("javascript");
            Console.WriteLine(langs.Contains("c#"));

            Console.WriteLine(langs[0]);
            Console.WriteLine(langs[1]);

            langs.Remove("c#");
            langs.Remove("c");

            Console.WriteLine(langs.Contains("C#"));
            langs.Insert(4, "haskell");
            langs.Sort();
            foreach (string lang in langs) 
                
                Console.WriteLine(lang);
            Console.ReadKey();


        }
    }
}
