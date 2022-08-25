using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resource_file
{
    public class Directory_3
    {
        public static void fn3()
        {
            
            Console.WriteLine("Enter directory name:");
            Directory.CreateDirectory(@"G:\C#\Day6\File_stream\File_stream\");
            string s = Console.ReadLine();
            DirectoryInfo di = new DirectoryInfo(s);

            Console.WriteLine("Directory created !!");
            Console.WriteLine("Enter no of subdirectories to be created:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter subdirectory name:");
                string s1 = Console.ReadLine();

                DirectoryInfo dis = di.CreateSubdirectory(s1);


            }


           Console.WriteLine("Subdirectories created !!");

            string[] fnames = Directory.GetDirectories(@"G:\C#\Day6\File_stream\File_stream\bin\Debug\Results");
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(fnames[i]);
                for (int j = 0; j < 2; j++)
                {
                    string k = Console.ReadLine();
                     string v = string.Concat(fnames[i], k);
                    //string v = (fnames[i] + k );
                    File.Create(@v) ;

                }
                Console.WriteLine("2 files created..");
            }
            Console.WriteLine("Files are successfully  created..");
            Console.WriteLine("In Sub-directory create Monthwise folders:");
            for (int i = 0; i < 3; i++)
            {
                DirectoryInfo dname = new DirectoryInfo(fnames[i]);
                for (int j = 1; j <= 12; j++)
                {
                    var a = (Months)j;
                    string r = a.ToString();
                    dname.CreateSubdirectory(r);

                    Console.ReadLine();

                }
                Console.WriteLine("12 months are created.");
            }
            Console.WriteLine("Created successfully");

            var dirs = from dir in Directory.EnumerateDirectories(s) select dir;
            Console.WriteLine("Subdirectories: {0}", dirs.Count<string>().ToString());
            Console.WriteLine("List of Subdirectories");
            foreach (var dir in dirs)
            {
                Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
            }

            var files = from file in Directory.EnumerateFiles(s) select file;
            Console.WriteLine("Files: {0}", files.Count<string>().ToString());
            Console.WriteLine("List of Files");
            foreach (var file in files)
            {
                Console.WriteLine("{0}", file);
            }
            Console.ReadKey();

        }
        enum Months
        {
            Jan = 1,
            Feb,
            Mar,
            Apr,
            May,
            June,
            July,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec
        }
            
    }
}