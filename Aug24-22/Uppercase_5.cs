using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reusablecode_library
{
    public class Uppercase_5
    {
        public static void upper_5(String s)
        {
            Console.WriteLine("Convert string into uppercase: ");
            Console.WriteLine("-----------------------------------");

            string upperstr1 = s.ToUpper();

            Console.WriteLine("The UpperCase of {0} is {1}",s,upperstr1);
        }
    }
}
