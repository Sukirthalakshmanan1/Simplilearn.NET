using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Firstname which acts as  a Username:");
            string s = Console.ReadLine();
            Console.WriteLine("Enter Lastname which acts as  password:");
            string pass= Console.ReadLine();
            if (s == "SukirthaLakshmanan" && pass == "Sukilax")
            {
                Console.WriteLine("Success!!!  Welcome to my app");
            }
            else
            {
                Console.WriteLine("Incorrect Username or Password ");
            }
            Console.ReadKey();
        }
    }
}
