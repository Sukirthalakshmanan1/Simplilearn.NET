using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_11
{
    internal class Hash_8
    {
        static void Main(string[] args)
        {
            Hashtable a=new Hashtable();
            a.Add(1, "Lotus");
            a.Add(2, "Jasmine");
            a.Add(3, "lily");
            a.Add(4, "hibiscus");
            IDictionaryEnumerator ie = a.GetEnumerator();
            Console.WriteLine("The elements in hash table are: ");
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Key + "  " + ie.Value);
            }
            Console.WriteLine("-----------------------------------");
            a.Remove(2);
            Console.WriteLine("After removing the element 2:");

            IDictionaryEnumerator h = a.GetEnumerator();

            while (h.MoveNext())
            {
                Console.WriteLine(h.Key + "  " + h.Value);
            }

            Console.ReadLine();

        }
    }
}
