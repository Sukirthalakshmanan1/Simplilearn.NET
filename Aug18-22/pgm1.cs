using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm2
{
    internal class Program
    {
           
            //pbm stmt 1
            static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
         static void Swapvalues( int x,  int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int a, b; 
            //int temp = 0;
            
            Console.WriteLine("Enter two numbers to swap:");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            Swap(ref a, ref b);
            Console.WriteLine("After Swapping by Reference:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("After Swapping by values:");
            Swapvalues(a,b);
            Console.WriteLine(a);
            Console.WriteLine(b);


            Console.ReadKey();
}}}

