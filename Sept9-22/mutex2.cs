using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_pgms
{
    internal class mutex2
    {
        static void Main(string[] args)
        {
            mutex_1 cc = new mutex_1();
            Console.WriteLine("----Mutex----");

            for (int i = 0; i < cc.numThreads; i++)
            {
                Thread mycorner = new Thread(new ThreadStart(cc.mutexprocess));
                mycorner.Name = String.Format("Thread {0}", i + 1);
                mycorner.Start();
                mycorner.Priority = ThreadPriority.Highest;
            }


            Console.ReadKey();
        }
    }
}
