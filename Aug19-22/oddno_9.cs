using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_firstpgm
{
    internal class oddno_9
    {
        static void Main(string[] args)
        {
            int n, i,sum = 0;
            Console.Write("Enter number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Odd numbers are :");
            for (i = 1; i <= n; i++)
            {
                int c = 2 * i - 1;
                Console.Write("{0} ",c );
                sum += c;
            }
            Console.Write("\nSum of odd Natural Number upto {0} terms : {1} \n", n, sum);
            Console.ReadLine();
        
    }
    }
}
