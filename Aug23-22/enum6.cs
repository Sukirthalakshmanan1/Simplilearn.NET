using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_functions
{
    internal class enum6
    {
        enum dept
        {
            Purchase = 1, Sales = 2, Training = 3, Accounts = 4
        };
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the dept name:");

           //string s=Console.ReadLine();
            /* dept s1 = dept.Purchase.GetType();
            dept s2 = dept.Sales;
            Console.WriteLine(s1);*/

            foreach (string i in Enum.GetNames(typeof(dept))) {
                
                Console.WriteLine(i);
        }

           foreach (int i in Enum.GetValues(typeof(dept)))
            {
                //if(i==(dept)i)
                
                Console.WriteLine(i+" "+(dept)i);
            }
            Console.ReadLine();
        }
    }
}
