using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_generic_classess
{
    internal class Linked_custom
    {
        static void Main(string[] args)
        {
             UserStack<int> a = new UserStack<int>();
             
            Console.WriteLine("Stack Empty= " + a.isStackEmpty());
            Console.WriteLine("---------------------------");
            Console.WriteLine("To pop:");
            a.Pop();
            Console.WriteLine("---------------------------");

            Console.WriteLine("Enter no of elements to be added in stack:");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter {0} elements :", n);
            for (int i = 0; i < n; i++)
            {
                int a1 = Convert.ToInt32(Console.ReadLine());
                a.Push(a1);
            }
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Elements in Stack:");
            a.PrintStackElements();

            Console.WriteLine("---------------------");
            Console.WriteLine("Popped element: ");
            a.Pop();
            Console.WriteLine("---------------------");
            Console.WriteLine("Peek element:");
            a.Peek();
            Console.WriteLine("---------------------");
            Console.WriteLine("Elements in Stack:");
            a.PrintStackElements();
            Console.WriteLine("Stack Empty= " + a.isStackEmpty());


            Console.ReadKey();
        }
    }
    }

