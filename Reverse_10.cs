using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_firstpgm
{
    internal class Reverse_10
    {
        static void Main(string[] args)
        {
            int n, rev = 0, r;
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                r = n % 10;
                rev = rev * 10 + r;
                n /= 10;
            }
            Console.Write("The Reverse Number is "+rev);
            Console.ReadKey();
        }
    
    }
}
