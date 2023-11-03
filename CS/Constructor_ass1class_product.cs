using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_ass1class_product
{
    class Product
    {
        int Productid;
        string Productname;
        int price, quantity;
        //creating a constructor with no parameters
        public Product()
        {
            Productid = 1;
            Productname = "cloth";
            price = 500;
            quantity = 3;



        }
        public void display()
        {
            Console.WriteLine("Product id = " + Productid);
            Console.WriteLine("Product name= " + Productname);
            Console.WriteLine("Product price= " + price);
            Console.WriteLine("Product quantity= " + quantity);



        }

    }
    class program
    {
        static void Main(string[] args)

        {
            Product product = new Product();
            product.display();
            Console.ReadLine();
        }

    }

}
