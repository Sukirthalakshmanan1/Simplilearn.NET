using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_11
{
    internal class Stack_6
    {
        static void Main(string[] args)
        {
            Stack s=new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(300.21f);
            //s.Push("Hello");
            s.Push(100);
            Console.WriteLine("The elements pushed in stack are:");
            foreach (var item in s)
                Console.WriteLine(item);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("The element poped out is:");
            object a=s.Pop();
            Console.WriteLine(a);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("After popping:");
            foreach(var item in s)
                Console.WriteLine(item);

            Console.WriteLine("-----------------------------------");

            object peek1 =s.Peek();
            Console.WriteLine("The element that is in peek in stack is:"+peek1);
            int total = s.Count;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Total elements in stack is:"+total);

            Console.ReadLine();
        }
    }
}
