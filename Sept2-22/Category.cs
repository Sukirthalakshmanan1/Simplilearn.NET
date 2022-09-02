using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1
{
    //1
    public class Category
    {
        //4
        static int product_count;
        private int catid;
        private string catname;
        private string description;


        public int Cat_id
        {
            get { return catid; }
            set { catid = value; }
        }

        public string Cat_Name
        {
            get { return catname; }
            set { catname = value; }
        }

        public string Cat_desc
        {
            get { return description; }
            set { description = value; }
        }

        //8

        private List<Product> l;
        public List<Product> product1
        {
            get { return l; }
            set { l = value; }
        }
        //7
        public void AddCategory(int id, string name, string d)
        {

            catid = id;
            catname = name;
            description = d;
        }
        //9
        public void displaydetails()
        {
            Console.WriteLine("Category id:" + Cat_id);
            Console.WriteLine("Category name:" + Cat_Name);
            Console.WriteLine("Description:" + Cat_desc);
            Console.WriteLine("----------------------------------");

            Product p1 = new Product();
            Console.WriteLine("Enter id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter sale rate: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price:");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter measurements in grams:");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Quantity in hand:");
            int ha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Reorder level:");
            int r1 = Convert.ToInt32(Console.ReadLine());
            p1.Addproduct(id,  name,  s,  p,  m1,  ha,  r1);
            List<Product> list = new List<Product>();
            list.Add(p1);
            product_count ++;
            Console.WriteLine("--------------------------------");

            Product p2 = new Product();
            Console.WriteLine("Enter id:");
            int id1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product name:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter sale rate: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price:");
            int p11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter measurements in grams:");
            int m11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Quantity in hand:");
            int ha1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Reorder level:");
            int r11 = Convert.ToInt32(Console.ReadLine());
            p2.Addproduct(id1, name1, s1, p11, m11, ha1, r11);

            list.Add(p2);
            //p2.Addproduct(2, "Wheet", 100, 100, 10, 1, 14);
            product1 = list;
            product_count++; ;

            Console.WriteLine("--------------------------------");

            foreach (var i in product1)
            {
                Console.WriteLine("Product details:");
                Console.WriteLine("Product id:"+i.prod_id);
                Console.WriteLine("Product name:"+i.Prod_name);
                Console.WriteLine("Measurements:"+i.Measurement);
                Console.WriteLine("Product quantity in hand:"+i.Qty_in_hand);
                Console.WriteLine("Price:"+i.Price);
                Console.WriteLine("Reorder level:"+i.Reorder);
                Console.WriteLine("Quantity:"+i.quantity);
                Console.WriteLine("-----------------------------");

            }

           
            Console.WriteLine("Product count: " + product_count);
        }


    }
}
