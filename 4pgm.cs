using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_firstpgm
{
    internal class _4pgm
    {
        static void Main(string[] args)
        {
            String s1,s2;
            Console.WriteLine("Enter Strings to compare:");
            s1=Console.ReadLine();  
            s2=Console.ReadLine();
            if (s1 == s2)
            {
                Console.WriteLine("Strings are Equal");
                Console.WriteLine(s1 + " is equal to " + s2);
            }
            else
                Console.WriteLine(s1+" is Not Equal to "+s2);
            Console.ReadKey();

        }
    }
}
