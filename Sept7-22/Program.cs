using DelegateLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            DelegateClass d = new DelegateClass();
            DelegateClass.str s1 = new DelegateClass.str(d.Login);
            Console.WriteLine("Enter the Username:");
            string name = Console.ReadLine();
            s1(name);
            Console.WriteLine("-----------------------------------");

            DelegateClass.num a1 = new DelegateClass.num(d.add);
            a1 += d.sub;
            a1 += d.multiply;
            Console.WriteLine("Enter two numbers:");
            int a=Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            a1(a,b);
            Console.WriteLine("-----------------------------------");

            product p = new product();
           
            product.product1 w = new product.product1(p.Pro);
            Console.WriteLine("Product:");
            Console.WriteLine("Enter ID:");
            int i= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string name1 = Console.ReadLine();
            Console.WriteLine("-----------------------------------");

            w(i,name1);
            Console.WriteLine("-----------------------------------");
            //5

            Console.WriteLine("To calculate the year of experience:");
            Console.WriteLine("-----------------------------------");
            Employee e = new Employee();
            Employee.calc c = new Employee.calc(e.method);
            Console.WriteLine("Enter the year of joining:");
            int doj = Convert.ToInt32(Console.ReadLine());
            c(doj);

            Console.WriteLine("-----------------------------------");
            //6
          Concat cw = new Concat();
            Concat.concat1 cw1 = new Concat.concat1(cw.stmt);
            Console.WriteLine("Enter the string:");
            string n1 = Console.ReadLine();
            Console.WriteLine("Enter the other string:");

            string n2 =Console.ReadLine();
            cw1(n1, n2);
            //7
            Console.WriteLine("To convert First character to Uppercase: ");
            Console.WriteLine("-----------------------------------");

            Concat.concat2 aw = new Concat.concat2(cw.cap);
            aw();
                
            Console.ReadLine();
           
        }
    }
}
