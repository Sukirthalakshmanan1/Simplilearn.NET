using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Attribute
{
    internal class Program
    {
       
            static void Writedata(Type t)
            {
                Console.WriteLine("Method class: " + t.Name);

                System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);    

                foreach (System.Attribute ob in attrs)
                {
                    if (ob is Stereo_disc)
                    {
                        Stereo_disc a = (Stereo_disc)ob;
                        Console.WriteLine("Song style:"+a.songname);
                    
                    }
                }
                Console.WriteLine("---------------------------------");
                MemberInfo[] minfo = t.GetMembers();

                foreach (var item in minfo)
                {
                    System.Attribute[] attrs1 = System.Attribute.GetCustomAttributes(item);

                    foreach (System.Attribute item1 in attrs1)
                    {
                        if (item1 is Stereo_disc)
                        {
                             Stereo_disc a = (Stereo_disc)item1;
                            System.Console.WriteLine(a.songname);
                            System.Console.WriteLine(a.language);
                            System.Console.WriteLine(a.lyrics);
                        }
                    }

                }
            }
        static void Main(string[] args)
        {

            Program.Writedata(typeof(Song));
            Console.Read();
        }
    }
    }

