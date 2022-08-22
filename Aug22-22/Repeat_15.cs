using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_11
{
    internal class Repeat_15
    {
        public static int firstRepeated(int[] arr, int n)
        {
            
            Dictionary<int, int> mp = new Dictionary<int, int>();

            
            for (int i = 0; i < n; i++)
            {
                if (mp.ContainsKey(arr[i]))
                    mp[arr[i]]++;
                else
                    mp.Add(arr[i], 1);
            }
            int ans = -1;
           
            for (int i = 0; i < n; i++)
            {
                if (mp[arr[i]] > 1)
                {
                    ans = i + 1;
                    break;
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int i, n1;
            int[] a = new int[100];


            Console.Write("Enter the number of elements to store in the array :");
            n1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter {0}  elements :\n", n1);
            for (i = 0; i < n1; i++)
            {
                Console.Write("Element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Repeated element at first is:");
            Console.WriteLine(firstRepeated(a,n1));
            Console.ReadLine();
        }
    }
}
