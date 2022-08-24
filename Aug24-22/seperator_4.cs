using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Reusablecode_library
{
  public class seperator_4
    {
        public static void split4(String s)
        {
            String[] result = s.Split('#');
            

            Console.WriteLine("After splitting:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
