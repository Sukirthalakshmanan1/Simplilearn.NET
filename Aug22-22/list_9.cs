using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_11
{
    internal class list_9
    {
        static void Main(string[] args)
        {
                List<float> l = new List<float>();
            l.Add(1.2f);
            l.Add(7.0f);
            l.Add(3.3f);
            l.Add(9.3f);
            l.Add(5.4f);
            Console.WriteLine("The elements in list are:");
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("The list in ascending order:");
            l.Sort();
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");

            Console.WriteLine("The list in descending order:");
            l.Sort();
            l.Reverse();
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
