using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Assignment_Login
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Firstname which acts as  a Username:");
            string s = Console.ReadLine();
            Console.WriteLine("Enter Lastname which acts as  password:");
            string pass = Console.ReadLine();
            if (s == "SukirthaLakshmanan" && pass == "Sukilax")
            {
                Console.WriteLine("Success!!! " +s +" Welcome to my app");
            }
            else
            {
                Console.WriteLine("Incorrect Username or Password Kindly check!!");
            }
            Console.ReadKey();
        
    }
    }
}
