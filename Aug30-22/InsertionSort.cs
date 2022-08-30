using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class InsertionSort
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insertion sort:");
            int[] arr = new int[100];
            Console.WriteLine("Enter no of elements to be entered in array:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----------------------------------------------");

            Insertion_sort(arr, n);
            Console.WriteLine("After sorting by Insertion sort:");
            Display(arr, n);
            Console.Read();
        }
        static void Insertion_sort(int[] arr,int n)
        {

            int i, j, temp;
           
            for (i = 0; i < n; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && temp <= arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
        }

        static void Display(int[] arr,int n)
        {

          
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }


        
    }
}
