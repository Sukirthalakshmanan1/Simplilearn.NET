using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("The elements in the array list are: ");
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add("hello");
            list.Add("Jolly");
            list.Add(5);
            foreach (var item in list)
            {
                //string arrayItem = string.Format($"Name  is {item}");
                Console.WriteLine(item);
            }
            Console.WriteLine("After removing the item 1:");
            list.Remove(1);
            Console.WriteLine("----------------------------");
            foreach (var item in list)
            {
                
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            list.RemoveRange(0, 1);
            Console.WriteLine("After removing the items from range(0,1):");
            Console.WriteLine("----------------------------");
            foreach (var item in list)
            {

                Console.WriteLine(item);
            }
            int c=list.Count;
            Console.WriteLine("Count of ArrayList is:"+c);
            Console.ReadKey();
        }
    }
}
