using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_pgms
{
    //5
   public class Semaphore_1
    {
        static Thread[] ts = new Thread[10];
        static Semaphore s = new Semaphore(2,2);
        static void M1()
        {
            Console.WriteLine("{0} is waiting in line...", Thread.CurrentThread.Name);
            s.WaitOne();
            Console.WriteLine("{0} enters the code", Thread.CurrentThread.Name);
            Thread.Sleep(1000);
            Console.WriteLine("{0} is leaving the code", Thread.CurrentThread.Name);
            s.Release();
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                ts[i] = new Thread(M1);
                ts[i].Name = " Thread " + i;
                ts[i].Start();
            }
            Console.Read();
        }
    }
}
