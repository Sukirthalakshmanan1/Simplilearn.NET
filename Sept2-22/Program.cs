using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Category details:");
            Console.WriteLine("--------------------------------");

            //5
            Category c = new Category();
           
            c.AddCategory(11, "Groceries", "Sales is on..");
            
            c.displaydetails();
            Console.WriteLine("--------------------------------");
            Category c2 = new Category();
            Console.WriteLine("Enter category id:");
            int id= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Category name:");
            string name=Console.ReadLine();
            Console.WriteLine("Description:");
            string d=Console.ReadLine();
            Console.WriteLine("--------------------------------");

            c2.AddCategory(id, name, d);
            c2.displaydetails();
            
            Console.ReadKey();

        }
    }
}
