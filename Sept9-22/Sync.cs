using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_pgms
{
    internal class Sync
    {
        
         void PrintTable()
        {
            lock (this)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(i);

                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Synchronization !!");
            Sync l = new Sync();
            Thread t1 = new Thread(l.PrintTable);
            Thread t2 = new Thread(l.PrintTable);
            t1.Start();
            t2.Start();
            t1.Join();
            Console.Read();


        }
    }
}
