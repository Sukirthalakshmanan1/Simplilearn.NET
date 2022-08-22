using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_firstpgm
{
    internal class div12
    {
        static void Main(string[] args)
        {
            int i, sum = 0;

            Console.WriteLine("Numbers which are divisible by 9 are: ");
            for (i = 100; i <= 200; i++)
            {
                if (i%9==0) {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine("Sum is: " + sum);
            Console.ReadKey();
        
    }
    }
}
