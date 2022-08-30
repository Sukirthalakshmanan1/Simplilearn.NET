using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sample
{
    class Quicksort1
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Quick sort:");
            int[] arr = new int[100];
            Console.WriteLine("Enter no of elements to be entered in array:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----------------------------------------------");

            Quick(arr, 0, n - 1);
            Console.WriteLine("Display the sorted array:");
            Print(arr, n);
            Console.Read();
        }

        private static void Print(int[] arr, int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);

            }
        }

        private static void Quick(int[] arr, int first, int last)
        {
            if (first < last)
            {
                int a = Partition(arr, first, last);
                Quick(arr, first, a - 1);
                Quick(arr, a + 1, last);

            }

        }

        private static int Partition(int[] arr, int first, int l)
        {
            
            int pivot = arr[l];
            int i = (first - 1);
            for (int j = first; j <= l - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;

                }
            }
            int temp = arr[i + 1];
            arr[i + 1] = arr[l];
            arr[l] = temp;
            return (i + 1);
        }
    }
}
