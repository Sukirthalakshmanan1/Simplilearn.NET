using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_11
{
    internal class Reverse_2
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[100];


            Console.Write("Enter the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter {0} number of elements :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe elements stored into the array are : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }

            Console.Write("\n\n The elements stored into the array in reverse are :\n");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.ReadKey();

        }
    }
}
