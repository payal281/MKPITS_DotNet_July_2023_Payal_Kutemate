﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Animal
{
    public string color = "white";

}
public class Dog : Animal
{
    public string color = "black";
}
public class TestSealed
{
    public static void Main()
    {
        Animal d = new Dog();
        Console.WriteLine(d.color);
        Console.ReadKey();

    }
}
