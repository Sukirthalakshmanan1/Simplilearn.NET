using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm2
{
    internal class Program
    {
// pbm stmt 15 -- USD to INR
        static void Main(string[] args)
        {
            double USD = 0;
            double inr = 0;
            double amt = 0;

            Console.Write("Enter amount in USD: ");
            USD = double.Parse(Console.ReadLine());

            Console.Write("Enter the USD value :");
           amt = double.Parse(Console.ReadLine());

            inr = USD * amt;
            Console.WriteLine("USD " + USD + " to INR value is " + inr);
            Console.ReadKey();
        }
        

   


}}