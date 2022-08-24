using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reusablecode_library
{
    public class Date_7
    {
        public static void date_pgm()
        {
            //Console.WriteLine("Enter date:");
            DateTime d = DateTime.Now;
            Console.WriteLine("Today:" + d);
            //d = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Year = " + d.Year);

            Console.WriteLine("Month = " + d.Month);

            Console.WriteLine("Day = " + d.Day);

            Console.WriteLine("Hour = " + d.Hour);

            Console.WriteLine("Minute = " +d.Minute);

            Console.WriteLine("Second = " + d.Second);

            Console.WriteLine("Millisecond = " + d.Millisecond);

        }
    }
}