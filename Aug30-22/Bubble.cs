using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Bubble
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Bubble sort:");
            int[] arr = new int[100];
            Console.WriteLine("Enter no of elements to be entered in array:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----------------------------------------------");

            Bubble_sort(arr,n);
            Console.Read();
        }
        static void Bubble_sort(int[] arr,int n)
        {

            int temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < (n - 1) - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Array using Bubble sort:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }

    }
    
}
