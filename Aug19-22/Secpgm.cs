using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_firstpgm
{
    internal class Secpgm
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Enter three numbers:");

            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 >= n2)
            {
                if (n1 >= n3)
                    Console.WriteLine( "The largest number is "+n1);
                else
                    Console.WriteLine("The largest number is "+n3);
            }

            else if (n2 >= n3)
                Console.WriteLine("The largest number is "+n2);

            else
                Console.WriteLine("The largest number is "+n3);

            Console.ReadLine();
        }
    }
}
