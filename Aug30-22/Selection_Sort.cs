using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Selection_Sort
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Selection sort:");
            int[] arr=new int[100];
            Console.WriteLine("Enter no of elements to be entered in array:");
             int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements:");
            for(int i=0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----------------------------------------------");
            SelectionSort(arr,n);
            Console.Read();

        }
        static void SelectionSort(int[] arr,int n)
        {
            int Min, i, j;
            //int len =n - 1;
            for (i = 0; i < n-1; i++)
            {
                Min = i;
                for (j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[Min])
                    {
                        Min = j;
                    }
                }
                if (Min != i)
                {
                    int t = arr[Min];
                    arr[Min] = arr[i];
                    arr[i] = t;
                }
            }

            Console.WriteLine("Sorted array using Selection sort:");
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(arr[k]);
            }

        }
    }
    
}
