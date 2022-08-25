using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resource_file
{
    public class Dir_4
    {
        public static void fn4()
        {
            Console.WriteLine("F drive info");
            DriveInfo info = new DriveInfo("F");
            Console.WriteLine(info.Name);
            Console.WriteLine(info.TotalSize);
            Console.WriteLine(info.DriveType);
            Console.WriteLine(info.DriveFormat);
            Console.WriteLine(info.VolumeLabel);
            Console.WriteLine(info.TotalFreeSpace);


            Console.WriteLine("----------------------------");
            DriveInfo[] dinfo = DriveInfo.GetDrives();
            foreach (var item in dinfo)
            {
                Console.WriteLine(item.Name);
                
                Console.WriteLine(item.DriveType);
               // Console.WriteLine(item.TotalFreeSpace);

                Console.WriteLine("----------------------------");

            }
            Console.ReadLine();
        }
    }
}
