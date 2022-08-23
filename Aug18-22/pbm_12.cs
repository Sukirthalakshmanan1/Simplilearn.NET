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
            Console.WriteLine("Enter String:");
            string s = Console.ReadLine();
            bool b = string.IsNullOrEmpty(s);
            Console.WriteLine(b);
            
            Console.ReadKey();
        }
}}