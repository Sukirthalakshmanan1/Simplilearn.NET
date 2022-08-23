using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_functions
{
    
    internal class Exception_8
    {
        public static void fn(int n1, int n2)
        {
            try
            {
                Console.WriteLine(n1 / n2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(" Exception ({0}) occurred.", e.GetType().Name);
                Console.WriteLine("Stack Trace:\n   {0}\n", e.StackTrace);
                Console.WriteLine("Message of error:{0}\n", e.Message);
                Console.WriteLine("Division of {0} by zero is the exception.", n1);


            }
        }
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Enter 2 numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            fn(a,b);
            
            Console.ReadLine();
        }
    }
}
