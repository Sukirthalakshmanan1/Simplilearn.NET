using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Booklib
{
    public class Novel : Book1
    {
        public Novel()
        {
        }
        public void insertbook(int bookid, string bookname, int price, int pages)
        {
            Console.WriteLine("Id:" + bookid);
            Console.WriteLine("Book name:" + bookname);
            Console.WriteLine("Price:" + price);
            Console.WriteLine("No of pages:"+pages);

            Console.WriteLine("--------------------------------");


        }
    }

    //13
    public abstract class Cust
    {
        public abstract void book_show();
       
        public void Show()
        {
            
            Console.WriteLine("Abstract class !!");
        }



    }
    public class bookshow:Cust
    {
        public override void book_show()
        {
            Console.WriteLine("Book cart shown !!!");
        }
    }



}
