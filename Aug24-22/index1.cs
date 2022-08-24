using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reusablecode_library
{

    public class index1
    {
        public static void findindex(String s1,char c)
        {
            
             int indexOfC = s1.IndexOf(c);
            Console.WriteLine("In string1 Index of {0} is {1} " ,c, indexOfC);

        }
    }
    
}
