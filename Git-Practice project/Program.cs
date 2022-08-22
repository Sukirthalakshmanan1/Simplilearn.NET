using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Studentdata
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
            string[] content = File.ReadAllLines("G:\\C#\\Student_Data.txt");

            foreach (string line in content)
                Console.WriteLine(line);
            Console.ReadLine();
        }
       

    }
}
