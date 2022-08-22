using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_11
{
    internal class Queue_7
    {
        static void Main(string[] args)
        {
           Queue q=new Queue();
            q.Enqueue(11);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(25);
            Console.WriteLine("The elements present in queue are:");
            foreach(var item in q)
                Console.WriteLine(item);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("The element dequeued is:");
            object o=q.Dequeue();
            Console.WriteLine(o);
            Console.WriteLine("-----------------------------------");


            Console.WriteLine("The element is in peek is:");
            object c = q.Peek();
            Console.WriteLine(c);

            Console.ReadLine();

        }
    }
}
