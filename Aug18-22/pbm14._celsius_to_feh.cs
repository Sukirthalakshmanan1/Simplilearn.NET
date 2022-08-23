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
            double f;

            double c ;
            Console.WriteLine("Enter Celsius:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Celsius: " + c);

            f = (c * 9) / 5 + 32;
            Console.WriteLine("Converted to Fahrenheit: " + f);

            Console.ReadLine();
        }

}}