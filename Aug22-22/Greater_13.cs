using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_11
{
    internal class Greater_13
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[100];


            Console.Write("Enter the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter {0}  elements :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Greater than 100 elements are displayed:");
            for (i = 0; i < n; i++)
            {
                if (a[i] > 100)
                {
                    Console.WriteLine(a[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
