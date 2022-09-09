using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_pgms
{
    //5
    internal class mutex_1
    {
        public static Mutex mutex = new Mutex();
        public  int num = 1;
        public  int numThreads = 4;
        public void mutexprocess()
        {
            for (int i = 0; i < num; i++)
            {
                method();
            }
        }
        public void method()
        {
            mutex.WaitOne();     
            Console.WriteLine("{0} has entered !!",Thread.CurrentThread.Name);
              
            Thread.Sleep(1000);    
            Console.WriteLine("{0} is leaving !! \r\n",Thread.CurrentThread.Name);
            mutex.ReleaseMutex();     
        }
    }
}
