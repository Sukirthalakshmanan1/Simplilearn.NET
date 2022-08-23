using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm2
{
    internal class Program
    {

//problem stmt 2
            static void Main(string[] args)
        {
         int i, j, k;
            Console.WriteLine("Enter 3 numbers to multiply:");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            int multiply = i * j * k;
            Console.WriteLine(i+"*"+j+"*"+k+"="+multiply);
            Console.ReadKey();
}}}
