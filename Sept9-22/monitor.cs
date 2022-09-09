using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_pgms
{
    internal class monitor
    {
        static object ls = new object();
        public void display()
        {

            Thread.Sleep(1000);
            WriteFile();

        }
       public void WriteFile()
        {
            Console.WriteLine("-----Simple Monitor class ----");
            string name = Thread.CurrentThread.Name;
            Console.WriteLine(name);
            Monitor.Enter(ls);

            try
            {

                using (FileStream fs = new FileStream("Numbers.txt", FileMode.Append, FileAccess.Write))
                {
                    StreamWriter w = new StreamWriter(fs);
                    w.WriteLine(name);
                    w.Close();
                    fs.Close();
                }




            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {


                Monitor.Exit(ls);
                Console.WriteLine(" ## Monitor class thread: " + name);

            }

        }
    }
    }
