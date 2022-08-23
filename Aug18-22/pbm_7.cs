using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm2
{
    internal class Program
    {
//pbm stmt 7 --2525 pbm
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter a digit: ");
            n = Convert.ToInt32(Console.ReadLine());

            
            Console.Write(n);
            Console.Write(" ");
            Console.Write(n);
            Console.Write(" ");
            Console.Write(n);
            Console.Write(" ");
            Console.Write(n);
            Console.WriteLine();

            
            Console.Write(n);
            Console.Write(n);
            Console.Write(n);
            Console.WriteLine(n);
            Console.WriteLine();
            
            Console.WriteLine("{0} {0} {0} {0}", n);

            Console.WriteLine("{0}{0}{0}{0}", n);
            Console.ReadKey();

        }

}}