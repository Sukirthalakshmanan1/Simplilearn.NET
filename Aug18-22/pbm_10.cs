using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm2
{
    internal class Program
    {
 static void Main(string[] args)
        {
            Console.WriteLine("Enter first Integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive and return the output:");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
            Console.ReadKey();
        }

}}