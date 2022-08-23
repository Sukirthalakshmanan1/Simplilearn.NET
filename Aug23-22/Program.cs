using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_functions
{
    internal class Program
    {
        public static int fn(int a1,int b1)
        {
            int c = a1 + b1;
            return c;

        }
        static void Main(string[] args)
        {
            int a, b,res;
            Console.WriteLine("Enter 2 numbers:");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of 2 numbers is");
            Console.WriteLine(res=fn(a,b));
            Console.ReadLine();
        }
    }
}
