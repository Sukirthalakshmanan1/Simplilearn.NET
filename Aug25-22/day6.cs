using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Resource_file
{
    public class day6
    {
        public static void fn()
        {
            // string path = @"G:\\C#\\";
            char c;
            do
            {
                Console.WriteLine("Enter the number:\n 1.To create a file: \n 2. to add file :\n 3.to truncate file:");
            int n=Convert.ToInt32(Console.ReadLine());
           
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter the file name");
                        string fname = Console.ReadLine();
                        FileStream fs = new FileStream(fname, FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        Console.WriteLine("Enter the content:");
                        String s = Console.ReadLine();

                        sw.Write(s);

                        sw.Close();
                        fs.Close();
                        Console.WriteLine("Content written successfully..");
                        break;
                    case 2:
                        Console.WriteLine("Enter the file name");
                        string name = Console.ReadLine();
                        FileStream fs1 = new FileStream(name, FileMode.Append, FileAccess.Write);

                        StreamWriter ss = new StreamWriter(fs1);
                        Console.WriteLine("Enter the content  to append:");
                        String s1 = Console.ReadLine();

                        ss.Write(s1);

                        ss.Close();
                        fs1.Close();
                        Console.WriteLine("Content appended/added successfully..");

                        break;

                    case 3:
                        Console.WriteLine("Enter the file name");
                        string name1 = Console.ReadLine();

                        FileStream fs2 = new FileStream(name1, FileMode.Truncate, FileAccess.Write);

                        StreamWriter ss1 = new StreamWriter(fs2);
                        /*Console.WriteLine("Enter the content  to delete:");
                        String con = Console.ReadLine();

                        ss1.Write(con);*/

                        ss1.Close();
                        fs2.Close();
                        Console.WriteLine("Content truncated successfully..");


                        break;



                }
                Console.WriteLine("press y to continue..");
                c=Convert.ToChar(Console.ReadLine());
            }while(c=='y'|| c=='Y');




        }

    }
}
