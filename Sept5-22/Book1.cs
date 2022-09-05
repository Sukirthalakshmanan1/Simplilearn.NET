using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booklib
{
    public class Book1
    {
        private int bookid;

        public int Id
        {
            get { return bookid; }
            set { bookid = value; }
        }

        private string bname;
        public string Bookname
        {
            get { return bname; }
            set { bname = value; }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private string a;
        public string author
        {
            get { return a; }
            set { a = value; }
        }
        public Book1()
        {
            Console.WriteLine("Default constructor called...Hello book !!");
            Console.WriteLine("--------------------------------");

        }
        public Book1(int bid, string name, int price1, string a1)
        {
            bookid = bid;
           
            bname = name;
            price = price1;
            a = a1;
            Console.WriteLine("Parameterized Constructor called ...");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Id:" + bookid);
            Console.WriteLine("Book name:" + bname);
            Console.WriteLine("Price:" + price);
            Console.WriteLine("Author:" + a);

            Console.WriteLine("--------------------------------");


        }
        public void insertbook(int bid, string bname, int p)
        {
            Console.WriteLine("Id:" + bid);
            Console.WriteLine("Book name:" + bname);
            Console.WriteLine("Price:" + p);


            Console.WriteLine("--------------------------------");

        }

        public void insertbook(int bid, string bname, int p, string aname)
        {
            Console.WriteLine("Id:" + bid);
            Console.WriteLine("Book name:" + bname);
            Console.WriteLine("Price:" + p);
            Console.WriteLine("Author:" + aname);

            Console.WriteLine("--------------------------------");

        }
        public void insertbook(int bid, string bname)
        {

            Console.WriteLine("Id:" + bid);
            Console.WriteLine("Book name:" + bname);

            Console.WriteLine("--------------------------------");


        }
    }
}
