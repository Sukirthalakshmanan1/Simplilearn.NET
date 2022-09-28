using BL;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Library Management System");
            Console.WriteLine("--------------------------------");
            Helperclass1 helper = new Helperclass1();
            
            Console.WriteLine("Enter ur choice:\n 1. Add book details \n 2.Add member details \n 3.Update member details \n 4.Login");
            int n = Convert.ToInt32(Console.ReadLine());
            BookClass p = new BookClass();
            switch (n)
            {
                case 1:

                    Console.WriteLine("Enter book id:");
                    p.Book_no = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter bookname:");
                    p.Bookname = Console.ReadLine().Trim();
                    Console.WriteLine("Enter book author:");
                    p.aName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter category title:");
                    p.Category = Console.ReadLine().Trim();
                    Console.WriteLine("Enter cost of book:");
                    p.amt = Convert.ToSingle(Console.ReadLine());


                    bool queryStatus = helper.AddBook(p);
                    if (queryStatus)
                    {
                        Console.WriteLine("Book added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter member id");
                    p.member_id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter member name");
                    p.member_name = Console.ReadLine().Trim();



                   bool queryStatuss = helper.AddMember(p);
                    if (queryStatuss)
                    {
                        Console.WriteLine("Member added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter member id ");
                    p.member_id = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Enter member name");
                    p.member_name = Console.ReadLine().Trim();


                    bool queryStatuse = helper.Editmember(p);
                    if (queryStatuse)
                    {
                        Console.WriteLine("members details updated successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    
                    break;
                case 4:
                    Console.WriteLine("Enter user id:");
                    p.userid = Console.ReadLine();
                    Console.WriteLine("Enter Password:");
                    p.Password=Console.ReadLine();
                    bool q = helper.Adduser(p);
                    if (q)
                    {
                        Console.WriteLine("Logged in successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    Console.WriteLine("List of Books ...");
                    List<BookClass> list = new List<BookClass>();
                    list = helper.ShowEmployeeList();
                    foreach (var item in list)
                    {
                        Console.WriteLine(item.Book_no+" "+ item.Category+" "+ item.amt + " ");
                        Console.WriteLine(item.Bookname);
                       
                        
                    }

                    break;
            }
            Console.Read();

        }
        }
}
