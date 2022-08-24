using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Reusablecode_library;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two strings:");
            String s1=Console.ReadLine();
            String s2=Console.ReadLine();
            Console.WriteLine("------------------------");
            //1
            sample_class.Printstring(s1,s2);
            Console.WriteLine("================================");

            //2
            copy_2cs.fn(s1,s2);
            Console.WriteLine("================================");


            //3
            Console.WriteLine("IndexOf() method: ");
            Console.WriteLine("-----------------------");

            //Console.WriteLine("--------------------------");
            Console.WriteLine("Enter a character to find the index:");
            char c = Convert.ToChar(Console.ReadLine());

            index1.findindex(s1,c);
            
            Console.WriteLine("================================");

            //4
            Console.WriteLine("Split() method example:");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Enter a string:");
            String s=Console.ReadLine();
            seperator_4.split4(s);
            Console.WriteLine("================================");
//5
            Uppercase_5.upper_5(s);
            Console.WriteLine("================================");
            //6
            sample_demo_file.create_file();
            Console.WriteLine("================================");
            //7
            Console.WriteLine("Display the Day properties:");
            Date_7.date_pgm();
           

            Console.ReadLine();
        }
    }
}
