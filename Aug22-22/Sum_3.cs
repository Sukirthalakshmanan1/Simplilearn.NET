using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_11
{
    internal class Sum_3
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            int[] a = new int[100];


            Console.Write("Enter the number of elements in the array :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter {0} elements :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
                sum += a[i];
            }
            Console.Write("The sum of all elements in the array is:" + sum);
            Console.ReadKey();

        }
    }
}
