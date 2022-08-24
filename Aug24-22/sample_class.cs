using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reusablecode_library
{
    public class sample_class
    {
        public static void Printstring(String s1,String s2)
        {
            Console.WriteLine("Compare two strings:");
            Console.WriteLine("--------------------------");

            if (s1 == s2)
            {
                Console.WriteLine(s1 + " is equal to " + s2);
            }
            else
            {
                Console.WriteLine(s1+" is not equal to "+s2);
            }
            
           
        }

    }
    
}
