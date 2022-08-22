using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_11
{
    internal class Array_1
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int i;
            Console.WriteLine("Enter 10  elements in an array:");
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("Element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Elements in the array are : ");
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.Write("\n");
            Console.ReadKey();

        }
    }
}
