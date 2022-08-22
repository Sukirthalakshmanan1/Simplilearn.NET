using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_firstpgm
{
    internal class Biggestno_5
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter two numbers:");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            //n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("The biggest number is " + n1);
            }
            else
                Console.WriteLine("The biggest number is " + n2);
            Console.ReadKey();
        }
    }
}
