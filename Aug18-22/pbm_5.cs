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
            int x, y, z;
            Console.WriteLine("Enter x y and z:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            int res = (x + y) * z;
            int sum = (x * y) + (y * z);
            Console.WriteLine("result of (x+y).z is "+res);
            Console.WriteLine("Result of (x.y)+(y.z ) is "+sum);
            Console.ReadLine();
        }

}}