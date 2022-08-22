using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_11
{
    internal class Dict_11
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Sukirtha L");
            dict.Add(2, "Murugesh L");
            dict.Add(4, "Rekha M S V");
            dict.Add(3, "Lakshmanan K");
            dict.Add(5, "Ajith R");
            Console.WriteLine("The key and value are displayed using Dictionary:");

            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Sorted dictionary:");
            /*SortedDictionary<int, string> My_dict =new SortedDictionary<int, string>();
            My_dict.Add(1, "Sukirtha L");
            My_dict.Add(2, "Murugesh L");

            My_dict.Add(4, "Rekha M S V");
            My_dict.Add(3, "Lakshmanan K");
            My_dict.Add(5, "Ajith R");*/

            foreach (KeyValuePair<int, string> item in dict.OrderBy(a => a.Key))
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }


            Console.ReadKey();

        
    }
    }
}
