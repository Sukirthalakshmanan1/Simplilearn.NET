using Abstractlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Person p;
            p=new Employee();
            p.work();
            Console.WriteLine("-----------------------------");
            p=new Manager();
            p.work();
            Console.WriteLine("-----------------------------");

            p = new clerk();
            p.work();
            Console.WriteLine("-----------------------------");

            Savings s=new Savings();
            Console.WriteLine("Enter the amount present in bank:");
           int a = Convert.ToInt32(Console.ReadLine());
            s.Printbalance(a);
            
            s.CalculateInterest();
            s.Withdraw();
            s.Deposit1();
            Console.WriteLine("-----------------------------");
         
            Current c=new Current();
            c.Printbalance(100);
            Console.WriteLine("Interest:");
            c.CalculateInterest();
            c.Withdraw1();
            c.Deposit();
            
            Console.ReadKey();

        }
    }
}
