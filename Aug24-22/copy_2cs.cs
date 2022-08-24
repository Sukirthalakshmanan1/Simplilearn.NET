using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reusablecode_library
{
    public class copy_2cs
    {
        public static void fn(String s1,String s2)
        {
           // Console.WriteLine("================================");
            Console.WriteLine("Copy the String1 in string 2 :");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Before copying string 2 is: "+s2);
            s2 = String.Copy(s1);
            Console.WriteLine("After copying String 2 is:" + s2);

        }
    }
}
