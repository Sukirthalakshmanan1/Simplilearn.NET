using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booklib
{
    //10
    public class Cart:Book1, Book_Interface
    {
        private int cusid;
        //12
        static int count;
        public int customer_Id
        {
            get { return cusid; }
            set { cusid = value; }
        }
        private int book1_id;

        public int Book_Id
        {
            get { return book1_id; }
            set { book1_id = value; }
        }
        private int p1;

        public int b_price
        {
            get { return p1; }
            set { p1= value; }
        }
        //11---List all the books from the cart.

        public List<Book1> bList = new List<Book1>();
        public List<Book1> ProductList()
        {
            
            return bList;
        }
        private List<Book1> l;
        public List<Book1> product1
        {
            get { return l; }
            set { l = value; }
        }
        public void Add_To_Cart()
        {
            Console.WriteLine("Enter no of books to add:");
           int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Books in Cart:");
            Console.WriteLine("--------------------------------");

            for (int i = 1; i <= n; i++)
            {
                Book1 q = new Book1();
                Console.WriteLine("Enter Book id,book name,author,Price:");
                q.Id = Convert.ToInt32(Console.ReadLine());
                q.Bookname = Console.ReadLine();
                q.author = Console.ReadLine();
                q.Price = Convert.ToInt32(Console.ReadLine());

                bList.Add(q);
                product1 = bList;
                Console.WriteLine("Success !!");
                count++;
            }
            Console.WriteLine("Count of Books added to cart:"+count++);
            Console.WriteLine("--------------------------------");

        }
        

    }
}
