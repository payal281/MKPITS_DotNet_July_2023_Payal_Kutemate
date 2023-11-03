using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_with4parameter
{
    class Book
    {
        int Bookid;
        string title;
        string author;
        int price;
        //creating a constructor with no parameters
        
        public Book()
        {
            Console.WriteLine("construcor with no parameters called");
            Bookid = 123;
            title = "vb.net";
            author = "roshan kumar";
            price = 5235; 
        }
        //creating a parameterized constructor with 4 parameters
        public Book(int Bookid, string Title, string Author, int Price)
        {
            Console.WriteLine("constructor with parameters called");
            this.Bookid = Bookid;
            this.title = Title; 
            this.author = Author;   
            this.price = Price; 
        }
        public void display()
        {
            Console.WriteLine("book id :" +Bookid);
            Console.WriteLine("title :" + title);
            Console.WriteLine("author :" + author);
            Console.WriteLine("price :" + price);

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book(); //this will call constructor with no parameter automatically
            b1.display();


            Book b2 = new Book(22, "oracle", "ashis", 400); //this will call parameterized constructor
            b2.display();
            Console.ReadKey();

        }
    }
}
