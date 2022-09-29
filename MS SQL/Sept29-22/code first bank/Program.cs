using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{

    internal class Program
    {
        static void Main(string[] args)
        {
            MyContext2 context = new MyContext2();
            context.LoanTable.Add(new Loan { LoanID = 1, Loantype = "Personal", Amount = 100000, duration = 5, RateInterest = 0.5 });

            context.BTable.Add(new Borrower { borrower_id=1,borrower_name="Sam",City="kanchi",state="Tamil nadu",country="India",street=1,companyname="HCL",jobname="manager"});
             context.SaveChanges();
            Console.WriteLine("done");
            char c;
            borroweroperation co = new borroweroperation();
            Borrower1 bal = new Borrower1();

            do
            {
                Console.WriteLine("Enter your choice:\n 1.Add borrower details \n 2.Update borrower details \n 3.Delete borrower details \n 4.show all borrowers \n 5.Count Books");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:


                        Console.WriteLine("Enter Borrower id:");

                        bal.Bid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Borrower name :");
                        bal.BName = Console.ReadLine();

                        Console.WriteLine("Enter state:");
                        bal.state = Console.ReadLine();
                        Console.WriteLine("Enter city name:");
                        bal.city = Console.ReadLine();
                        Console.WriteLine("Enter company name:");
                        bal.CName = Console.ReadLine();
                        Console.WriteLine("Enter Job title:");
                        bal.JName = Console.ReadLine();
                        Console.WriteLine("Enter country:");
                        bal.country = Console.ReadLine();
                        Console.WriteLine("Enter street:");
                        bal.streetno = Convert.ToInt32(Console.ReadLine());

                        co.Add(bal);
                        Console.WriteLine("Record Inserted successfully...");
                        Console.WriteLine("---------------");


                        break;

                    case 2:
                        Console.WriteLine("Update Borrower details:");
                        Console.WriteLine("----------------------------");

                        Console.WriteLine("enter borrower id  to update:");

                        bal.Bid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Borrower name :");
                        bal.BName = Console.ReadLine();

                        Console.WriteLine("Enter state:");
                        bal.state = Console.ReadLine();
                        Console.WriteLine("Enter city name:");
                        bal.city = Console.ReadLine();
                        Console.WriteLine("Enter company name:");
                        bal.CName = Console.ReadLine();
                        Console.WriteLine("Enter Job title:");
                        bal.JName = Console.ReadLine();
                        Console.WriteLine("Enter country:");
                        bal.country = Console.ReadLine();
                        Console.WriteLine("Enter street:");
                        bal.streetno = Convert.ToInt32(Console.ReadLine());


                        co.Updatedetails(bal);
                        Console.WriteLine("Updated successfully....");
                        Console.WriteLine("----------------------------");


                        break;
                    /* case 3:
                         Console.WriteLine("Delete book using bookid:");
                         Console.WriteLine("----------------------------");
                         Console.WriteLine("Enter bookid to delete");
                         int bid = Convert.ToInt32(Console.ReadLine());
                         co.Delete(bid);
                         Console.WriteLine("Deleted successfully....");

                         Console.WriteLine("----------------------------");

                         break;*/

                    case 4:
                        List<Borrower1> customers = co.GetAllBooks();


                        foreach (var item in customers)
                        {
                            Console.WriteLine(item.Bid + "  " + item.BName + "  " + item.city + "  " + item.state);
                        }

                        Console.WriteLine("--------------------------");

                        break;
                    case 5:
                        co.Borrowercount();
                        break;
                }

                Console.WriteLine("Press y or Y to continue..");
                c = Convert.ToChar(Console.ReadLine());

            } while (c == 'y' || c == 'Y');





            Console.Read();
        }
    }
}
