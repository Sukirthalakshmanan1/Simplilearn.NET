using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DelegateLib
{
    public class DelegateClass
    {
        public delegate void str(string s);
       //1,2
        public void Login(string s)
        {
            Console.WriteLine("Hello "+s+"!! Have a successfull day !!");
            int l=s.Length;
            Console.WriteLine("Length of the Username is:"+l);
        }
        //3
        public delegate void num(int a, int b);
        public void add(int a,int b)
        {
            Console.WriteLine("Addition of two numbers:"+(a+b));
            Console.WriteLine("-----------------------------------");

        }
        
        public void sub(int a, int b)
        {
            if (b < a)
            {
                Console.WriteLine("Subtraction of two numbers:" + (a - b));
            }
            else
            {
                Console.WriteLine("{0} (B) is greater than {1}(A) so subtraction not possible ",b,a);
            }
            Console.WriteLine("-----------------------------------");

        }

        public void multiply(int a, int b)
        {
            Console.WriteLine("Multiplication of two numbers:" + (a * b));
        }
    }
}
