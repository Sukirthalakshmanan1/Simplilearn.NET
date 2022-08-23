using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm2
{
    internal class Program
    {
//pbm stmt 4
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Enter 4 numbers to find average of them:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            double res = a + b + c + d;
            Console.WriteLine("Average is " +res+"/4");
            Console.ReadKey();
        }


}}