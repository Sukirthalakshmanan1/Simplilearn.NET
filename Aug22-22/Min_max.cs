using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_11
{
    internal class Min_max
    {
        
        static void Main(string[] args)
        {
            
           
            int[] a = new int[] { 1,4,55,89,90};
            Console.WriteLine("The array elements are:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            
            Console.Write("Sorting the array:\n");
            Array.Sort(a);


            

             if (a.Length > 0)
             {

                 Console.WriteLine("Maximum number found in the array is: " + a[a.Length-1]);
                Console.WriteLine("Minimum number found in the array is: " + a[0]);

            }

            Console.ReadLine();

        }
    }
}
