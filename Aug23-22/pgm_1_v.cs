using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_functions
{
    internal class pgm_1_v
    {
       public static void fn(int a1, int b1)
        {
            int c = a1 + b1;
            Console.WriteLine("The sum of 2 numbers is: "+c);
            

        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 2 numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            
             fn(a, b);
            Console.ReadLine();
            
        }
    }
}
