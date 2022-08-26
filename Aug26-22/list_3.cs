using new_lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace arrays_student
{
    public class list_3
    {
        public static void addprod(List<Prod_3> list)
        { 
           Console.WriteLine("Enter no of products to be added:");
           int n = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                list.Add(new Prod_3());



                Console.WriteLine("Enter id:");
                list[i].Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name:");
                list[i].SName = Console.ReadLine();
                Console.WriteLine("Enter cost:");
                list[i].cost = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Added successfully!!");
                Console.WriteLine("------------------------------");
            }
            
        }
        public static void disp(List<Prod_3> list)
        {

            foreach (var item in list)
            {
                Console.WriteLine("Product Id:" + item.Id);
                Console.WriteLine("Product Name:" + item.Name);
                Console.WriteLine("Cost :" + item.cost);

            }
            Console.WriteLine("------------------------------");

        }
        public static void removeprod(List<Prod_3> list)
        {
            Console.WriteLine("Enter product id to be deleted:");
            int a = Convert.ToInt32(Console.ReadLine());
            Prod_3 p=list.Find(item=>item.Id == a);
            list.Remove(p);

            Console.WriteLine("Removed Successfully!!");
            Console.WriteLine("------------------------------");


        }
        static void Main(string[] args)
        {
            
            List<Prod_3> list = new List<Prod_3>();
            char c;
            Console.WriteLine("Product program:");
            Console.WriteLine("------------------------------");

            //addprod(list);
            // disp(list);
            do
            {
                Console.WriteLine("Enter your choice: \n 1.Add \n 2.Remove  ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                switch (n1)
                {
                    case 1:
                       

                        addprod(list);
                        disp(list);
                        break;
                    case 2:
                        removeprod(list);
                        disp(list);
                        break;
                    
                }
                Console.WriteLine("Do u want to continue press y or Y:");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'y' || c == 'Y');

            Console.WriteLine("Total products:");
            Console.WriteLine(list.Count());

            Console.Read();

        }
    }
}
