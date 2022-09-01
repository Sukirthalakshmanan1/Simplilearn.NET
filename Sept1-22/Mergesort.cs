using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class Mergesort
    {
        
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            Console.WriteLine("Merge sort:");
            Console.WriteLine("Enter no.of elements in array:");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Enter elements in array:");
            for(int i=0; i<n; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Before sorting the array :");
            Console.WriteLine("-------------------------------");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            sorting(arr, 0, n - 1);

            Console.WriteLine("-------------------------------");


            Console.WriteLine("After sorting by merge sort:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
            Console.ReadLine();

        }
        static void sorting(int[] arr, int l, int h)
        {
            int mid;
            if (l < h)
            {
                mid = (l + h) / 2;
                sorting(arr, l, mid);
                sorting(arr, mid + 1, h);
                merge(arr, l, mid, h);

            }
            else
            {
                return;
            }

        }

        private static void merge(int[] arr, int l, int mid, int high)
        {
            
            int[] a = new int[100];
            int l1 = 0, l2 = 0, i;
            for (l1 = l, l2 = mid + 1, i = l; l1 <= mid && l2 <= high; i++)
            {

                if (arr[l1] <= arr[l2])
                {
                    a[i] = arr[l1++];
                }
                else
                {
                    a[i] = arr[l2++];
                }

            }
            while (l1 <= mid)

                a[i++] = arr[l1++];

            while (l2 <= high)

                a[i++] = arr[l2++];

            for (i = l; i <= high; i++)

                arr[i] = a[i];

           
        }
    }
}
