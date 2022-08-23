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
            int i;
            Console.WriteLine("Enter your age:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than "+i);
            Console.ReadKey();
        }

}}