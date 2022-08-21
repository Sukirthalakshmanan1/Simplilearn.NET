using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_firstpgm
{
    internal class Character_Comparision_3
    {
        static void Main(string[] args)
        {
            char c1, c2;

            Console.WriteLine("Enter the first character of String to check: ");
            c1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the second character of string to check : ");
            c2 = Convert.ToChar(Console.ReadLine());
            

            if (c1.Equals(c2))
                Console.WriteLine("Both characters are equal");
            else
                Console.WriteLine("Characters are not equal");
            Console.ReadKey();
        }
}
}
