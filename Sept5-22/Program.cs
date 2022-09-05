using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booklib;
namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Book1 b=new Book1();
            Book1 c = new Book1(1,"Ponniyian selvan",1000,"Cholas");
            Book_category b1 = new Book_category();
            Book_category c1 = new Book_category(1,"Story book","Children");
            b.insertbook(11, "Cindrella");
            b.insertbook(110,"Story books",1400);
            c.insertbook(45,"Jim jam",100,"Sara");
            Novel n = new Novel();
            n.insertbook(10, "Shinchan", 1000, 100);
            n.insertbook(1, "Raja Rani", 1000);
           Cart cq =new Cart();
            cq.Add_To_Cart();
            List<Book1> plist = new List<Book1>();
            plist=cq.ProductList();
            Console.WriteLine("List of books:");
            foreach(var item in plist)
            {
                Console.WriteLine("Id:"+item.Id);
                Console.WriteLine("Book name:"+item.Bookname);
                Console.WriteLine("Price:"+item.Price);
                Console.WriteLine("Author:"+item.author);
                Console.WriteLine("--------------------------------");
            }
            
            Cust s;
            s = new bookshow();
            s.Show();
            s.book_show();
           
            Console.ReadLine();
        }
    }
}
