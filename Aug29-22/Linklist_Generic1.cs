using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_generic_classess
{
    internal class Linklist_Generic1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Custom generic Linklist Implementation :");
            linkedList_1<int> a = new linkedList_1<int>();
            int a1 = 50;
            int b = 200;
            int c = 100;

            a.AddNode(a1);
            a.AddNode(b);
            a.AddNode(c);



            foreach (int item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------");


            linkedList_1<string> list = new linkedList_1<string>(); 
            string s1 = "Jose";
            string s2 = "Jam";
            string s3 = "Jill";
            string s4 = "Jack";

            list.AddNode(s1);
            list.AddNode(s2);
            list.AddNode(s3);
            list.AddNode(s4);


            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            

            Console.ReadKey();


        }
    }



}