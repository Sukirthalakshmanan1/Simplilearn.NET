using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_firstpgm
{
    internal class Sum_11
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            
            
            for (i = 100; i <= 200; i++)
            {
                sum += i;
            }
            Console.WriteLine(" Sum of all integers between 100 and 200 is: "+sum);
            Console.ReadKey();
        }
    }
}
