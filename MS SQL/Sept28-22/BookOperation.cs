using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BookOperation
    {
      public void Delete(int bookid)
        {

            ManagementEntities context = new ManagementEntities();
            context.DeleteBook(bookid);
            context.SaveChanges();
        }
      
        

        public void InsertBook(BLClass1 bal)
        {
            ManagementEntities context = new ManagementEntities();
            Book b=new Book();
            b.BookID = bal.Bookid;
            b.BookName = bal.BookName;
            b.Cost = bal.cost;
            b.MemberID = bal.memberid;
            context.Books.Add(b);
            context.SaveChanges();

        }

        public void UpdateBook(BLClass1 bal)
        {
            ManagementEntities context = new ManagementEntities();
            List<Book> customers = context.Books.ToList();
            Book obj = customers.Find(cust => cust.BookID== bal.Bookid);
            obj.BookName = bal.BookName;
            obj.Cost = bal.cost;
            obj.MemberID = bal.memberid;
           // context.Updatebookdetails();
            context.SaveChanges();

        }

        public void Bookcount()
        {
            ManagementEntities context = new ManagementEntities();

            Console.WriteLine("Book count : "+context.Books.Count());
        }
        public List<BLClass1> GetAllBooks()
        {
            ManagementEntities context = new ManagementEntities();

            List<Book> clist = context.Books.ToList();
            List<BLClass1> cblist = new List<BLClass1>();
            foreach (var item in clist)
            {
                cblist.Add(new BLClass1 { Bookid = item.BookID, BookName = item.BookName,cost= (int)item.Cost,memberid= (int)item.MemberID });



            }
            return cblist;




        }




    }
}
