using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c;
            BookOperation co = new BookOperation();
            BLClass1 bal = new BLClass1();
           
            do
            {
                Console.WriteLine("Enter your choice:\n 1.Add book \n 2.Update book details \n 3.Delete book \n 4.List of books \n 5.Count Books");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:

                        
                        Console.WriteLine("Enter Book id:");

                        bal.Bookid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Book name :");
                        bal.BookName = Console.ReadLine();

                        Console.WriteLine("Enter cost:");
                        bal.cost = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Member id:");
                        bal.memberid = Convert.ToInt32(Console.ReadLine());


                        co.InsertBook(bal);
                        Console.WriteLine("Record Inserted successfully...");
                        Console.WriteLine("---------------");


                        break;

                    case 2:
                        Console.WriteLine("Update Book details:");
                        Console.WriteLine("----------------------------");

                        Console.WriteLine("enter book id  to update:");
                        bal.Bookid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter Bookname:");
                        bal.BookName = Console.ReadLine();
                        Console.WriteLine("enter cost:");
                        bal.cost = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter member id:");
                        bal.memberid = Convert.ToInt32(Console.ReadLine());
                        co.UpdateBook(bal);
                        Console.WriteLine("Updated successfully....");
                        Console.WriteLine("----------------------------");


                        break;
                    case 3:
                        Console.WriteLine("Delete book using bookid:");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("Enter bookid to delete");
                        int bid = Convert.ToInt32(Console.ReadLine());
                        co.Delete(bid);
                        Console.WriteLine("Deleted successfully....");

                        Console.WriteLine("----------------------------");

                        break;

                    case 4:
                        List<BLClass1> customers = co.GetAllBooks();


                        foreach (var item in customers)
                        {
                            Console.WriteLine(item.Bookid + "  " + item.BookName + "  " + item.cost +"  "+ item.memberid);
                        }

                        Console.WriteLine("--------------------------");

                        break;
                    case 5:
                        co.Bookcount();
                        break;
                }

                Console.WriteLine("Press y or Y to continue..");
                c = Convert.ToChar(Console.ReadLine());

            } while (c == 'y' || c == 'Y');






            Console.Read();
        }
    }
}
