using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Reusablecode_library
{
    public class sample_demo_file
    {
        public static void create_file()
        {
            String path = @"G:\\C#\\Day5\\first.txt";
            File.Create(path);
            Console.WriteLine("File created..");
        }
    }
}

