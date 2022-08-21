using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_firstpgm
{
    internal class Even_13
    {
        static void Main(string[] args)
        {
             int n;
            Console.WriteLine("Enter a number: ");
            n=Convert.ToInt32(Console.ReadLine());
           
            if (n != 0)
            {
                if (n % 2 == 0 )
                {
                    Console.WriteLine("The given number is even");

                }

               
                else
                {
                    Console.WriteLine("the given number is odd");
                }
            }
            else
            {
                Console.WriteLine("The Given number is Zero");

            }

            if (n > 100)
            {
                Console.WriteLine("The given number is greater than 100");
            }

            if (n % 10 == 0 && n!=0) { 
                Console.WriteLine("The given number is multiple of 10");
            
            }
            Console.ReadLine();


        }
    }
}
