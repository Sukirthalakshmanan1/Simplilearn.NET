using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm2
{
    internal class Program
    {

public static double MToKm(double m)
        {
            double KM = 0;

            KM = m / 1000;

            return KM;
        }

        public static double KmToMeter(double km)
        {
            double d= 0;

            d = km * 1000;

            return d;
        }


        static void Main(string[] args)
        {
            double meter = 0;
            double km = 0;

            Console.Write("Enter the distance in meter : ");
            meter = double.Parse(Console.ReadLine());

            km = MToKm(meter);
            Console.WriteLine("Kilometer : " + km + " km");

            Console.Write("Enter the distance in kilometer: ");
            km = double.Parse(Console.ReadLine());

            meter = KmToMeter(km);
            Console.WriteLine("Meter : " + meter + " m");
            Console.ReadKey();


        }

}}