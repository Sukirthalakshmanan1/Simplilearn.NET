using new_lib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace arrays_student
{
    public class linkedlist_4
    {
        static void Main(string[] args)
        {
            LinkedList<Prod_3> l = new LinkedList<Prod_3>();

           // l.AddFirst(new Prod_3 { Id = 3, Name = "Pen", cost = 1000 });
           
            Prod_3 p=new Prod_3 ();
            Console.WriteLine("To Add first :");
            Console.WriteLine("Enter id:");
            p.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            p.SName = Console.ReadLine();
            Console.WriteLine("Enter cost:");
            p.cost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Added successfully!!");
            Console.WriteLine("------------------------------");
            l.AddFirst(p);
            Prod_3 p1 = new Prod_3();
            Console.WriteLine("To add last:");
            p1.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            p1.SName = Console.ReadLine();
            Console.WriteLine("Enter cost:");
            p1.cost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Added successfully!!");
            Console.WriteLine("------------------------------");
            l.AddLast(p1);

            l.AddBefore(l.Last.Previous, new Prod_3{ Id = 3, Name = "Pencil", cost = 20 });
            l.AddBefore(l.First.Next, new Prod_3 { Id = 5, Name = "Pen", cost = 200 });


            l.AddAfter(l.Last.Previous, new Prod_3 { Id = 4, Name = "Eraser", cost = 40 });
            

            l.AddBefore(l.Last, new Prod_3 { Id = 11, Name = "Alexa", cost=5000 });


            LinkedList<string> l1 = new LinkedList<string>();
            l1.AddFirst("Apple");

            LinkedListNode<string> foundnode = l1.Find("Apple");

            
            foreach (var item in l)
            {
                Console.WriteLine("Product ID:" + item.Id);
                Console.WriteLine("Product Name:" + item.Name);
                Console.WriteLine("Product Cost:" + item.cost);
                Console.WriteLine("----------------");
               
            }
            
            Console.WriteLine("Find the last node:");

           foreach (var item in l1)
            {
                
                Console.WriteLine("Product name:" + item);
                Console.WriteLine("----------------");

            }
            Console.WriteLine("Item found:" + foundnode.Value);


            Console.Read();

        }
    }
}
