﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp205
{
    interface bank
    {
        String deposit(int actno, int amount);
    }
    class saving : bank
    {
        int actno;
        int bal = 1000;
        int intrest = 1000;
        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            bal = bal + amount + interest;
            return "actno  : " + actno + " bal is : " + bal;
        }

    }
    class Current:bank
    {
        int actno;
        int bal = 1000;
        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            bal = bal + amount;
            return "actno  : " + actno + " bal is : " + bal;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b = null;
            Console.WriteLine("enter saving or current");
            string acttype =Console.ReadLine();
            switch(acttype) 
            {
                case "saving":
                    b= new saving(); break;
                case "current":
                    b=new Current(); break;
            }
            String res = b.deposit(1,700);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
