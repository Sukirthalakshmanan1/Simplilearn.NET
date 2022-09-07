using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateLib.DelegateClass;

namespace DelegateLib
{
    //6
    public class Concat
    {
        string sw;
        public delegate void concat1(string aa,string bb);
        public delegate void concat2();
        public void stmt(string aa,string bb)
        {
            sw = aa +" "+ bb;
            Console.WriteLine("Concatenation of two strings:"+sw);
            Console.WriteLine("-----------------------------------");

        }
        public void cap()
        {
            if (sw.Length == 0)
                System.Console.WriteLine("Empty String");
            else if (sw.Length == 1)
                System.Console.WriteLine(char.ToUpper(sw[0]));
            else
                System.Console.WriteLine(char.ToUpper(sw[0]) + sw.Substring(1));

        }
    }
}
