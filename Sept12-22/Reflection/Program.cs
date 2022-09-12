using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"G:\C#\Sep12\Calculator_1\calculator\bin\Debug\calculator.dll";
            Assembly asm = Assembly.LoadFrom(path);
            Type[] types = asm.GetTypes();
            Type t = null;
            
            foreach(var item in types)
            {
                t = asm.GetType(item.FullName);
                Console.WriteLine("To find Cube of a number:");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Enter a number:");
                double n=Convert.ToInt32(Console.ReadLine());
                object obj = Activator.CreateInstance(t);
                item.InvokeMember("cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { n });
                Console.WriteLine("---------------------------");
                Console.WriteLine("To find Sqrt of a number:");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Enter a number:");
                double n1 = Convert.ToInt32(Console.ReadLine());
                item.InvokeMember("sqrt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { n1 });

            }

            Console.ReadLine();
        }
    }
}
