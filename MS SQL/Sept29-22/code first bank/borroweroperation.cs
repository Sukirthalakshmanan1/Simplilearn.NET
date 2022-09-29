using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class borroweroperation
    {
        public void Delete(int bookid)
        {

            MyContext2 context = new MyContext2();
            // context.DeleteBook(bookid);
            context.SaveChanges();
        }



        public void Add(Borrower1 bal)
        {
            MyContext2 context = new MyContext2();

           Borrower b=new Borrower();
            b.borrower_id= bal.Bid;
            b.borrower_name = bal.BName;
            b.City= bal.city;
            b.street = bal.streetno;
            b.country = bal.country;
            b.companyname = bal.CName;
            b.jobname = bal.JName;
            b.state=bal.state;

            context.BTable.Add(b);
            context.SaveChanges();

        }

        public void Updatedetails(Borrower1 bal)
        {
            MyContext2 context = new MyContext2();
            List<Borrower> customers = context.BTable.ToList();
           Borrower obj = customers.Find(cust => cust.borrower_id== bal.Bid);
            obj.borrower_name = bal.BName;
            obj.City = bal.city;
           
            obj.country = bal.country;
            obj.street= bal.streetno;
            obj.companyname = bal.CName;
            obj.jobname = bal.JName;
            obj.state = bal.state;

            // context.Updatebookdetails();
            context.SaveChanges();

        }

        public void Borrowercount()
        {
            MyContext2 context = new MyContext2();

            Console.WriteLine("Count : " + context.BTable.Count());
        }
        public List<Borrower1> GetAllBooks()
        {
            MyContext2 context = new MyContext2();

            List<Borrower> clist = context.BTable.ToList();
            List<Borrower1> cblist = new List<Borrower1>();
            foreach (var item in clist)
            {
                cblist.Add(new Borrower1 { Bid = item.borrower_id, BName = item.borrower_name, city=item.City ,streetno=item.street,country=item.country ,state=item.state});



            }
            return cblist;




        }
    }
}


