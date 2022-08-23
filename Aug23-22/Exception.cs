using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_functions
{
    internal class Exception
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter 2 numbers: ");
            n1= Convert.ToInt32(Console.ReadLine());
            n2= Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(n1 / n2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(" Exception ({0}) occurred.", e.GetType().Name);
                Console.WriteLine("Stack Trace:{0}\n", e.StackTrace);
                Console.WriteLine("Message of error:{0}\n", e.Message);
                Console.WriteLine("Division of {0} by zero.", n1);


            }
            Console.ReadLine();
        }
    }
}
