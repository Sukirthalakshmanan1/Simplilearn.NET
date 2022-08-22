using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_11
{
    internal class cent_14
    {
        public static int count(int[] S, int m, int n)
        {
            
            if (n == 0)
                return 1;

          
            if (n < 0)
                return 0;

            if (m <= 0)
                return 0;

            return count(S, m - 1, n) +
                count(S, m, n - S[m - 1]);
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
        int m = n1;
            Console.WriteLine("Enter cents (n):");
            int n;
            n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("---------------------------");
        Console.WriteLine("The total number of solutions are: ");
        Console.Write(count(a, m, n));
        Console.ReadKey();

    }
}}

