using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
  internal  class Shell
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shell sort:");
            Console.WriteLine("Enter no of elements:");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");
            int[] arr = new int[100];
            Console.WriteLine("Enter elements in the array:");
            for(int i = 0; i < n1; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Before sorting:");
            print(arr, n1);
            Console.WriteLine("--------------------");

            Shellsort(arr,n1);
            Console.WriteLine("After sorting by shell sort:");
            Console.WriteLine("--------------------");

            print(arr, n1);
            Console.Read();
        }
        static void print(int[] arr,int n1)
        {
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

            static void Shellsort(int[] arr, int n)
        {
            int i, j, interval, t;
            
            Console.WriteLine("Enter the interval:");
            interval = Convert.ToInt32(Console.ReadLine());
            while (interval > 0)
            {
                for (i = 0; i < n; i++)
                {
                    j = i;
                    t = arr[i];
                    while ((j >= interval) && (arr[j - interval] > t))
                    {
                        arr[j] = arr[j - interval];
                        j = j - interval;
                    }
                    arr[j] = t;
                }
                if (interval / 2 != 0)
                    interval = interval / 2;
                else if (interval == 1)
                    interval = 0;
                else
                    interval = 1;
            }
        }
    }
}