using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Resource_file
{
    public class File2_2
    {
        public static void fn2()
        {
            Console.WriteLine("Enter the file name:");
            string fname = Console.ReadLine();
            string[] contents = new string[2];
            Console.WriteLine("Enter your file contents");

            string con = Console.ReadLine();
            contents[0] = con;
            File.WriteAllLines(fname, contents);
            Console.WriteLine("Content written successfully..");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Enter the file name to copy the file created :");
            string name = Console.ReadLine();

            File.Copy(fname, name);
            Console.WriteLine("-------------------------------");
            string p = "G:\\C#\\";
            File.Create(p + fname);
            Console.WriteLine("File copied to different folder !!");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Enter directory name to create:");
            string dname = Console.ReadLine();
            Directory.CreateDirectory(dname);
            Console.WriteLine("-------------------------------");
            //Console.WriteLine("File is moved to Move_File.txt");
            Console.WriteLine("Enter the file name to move the file created :");
            string name1 = Console.ReadLine();
            File.Move(fname, name1);
            Console.WriteLine("File {0} is moved to {1}",fname,name1);
            Console.WriteLine("-------------------------------");
            
            File.Delete(name);
            Console.WriteLine("Deleted the file {0}",name);

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Extension of the file:");
            
            FileInfo f = new FileInfo(fname);
            string extn = f.Extension;
            Console.WriteLine("File Extension: {0}", extn);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Path full name:"+f.FullName);
            Console.WriteLine("DirectoryName path:"+f.DirectoryName  );
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Creation time:"+f.CreationTime);

            Console.ReadKey();
            


        }
    }
}
