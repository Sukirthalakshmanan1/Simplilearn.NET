using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_pgms
{
   public class nameproperty
    {
        public void M2()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Print i ={0} ", i);
                Console.WriteLine("Thread name: " + Thread.CurrentThread.Name);
                Console.WriteLine("Thread state: " + Thread.CurrentThread.ThreadState);
                Console.WriteLine("Thread Background process: " + Thread.CurrentThread.IsBackground);
                Console.WriteLine("Thread alive: " + Thread.CurrentThread.IsAlive);
                Console.WriteLine("Thread Current UI culture: " + Thread.CurrentThread.CurrentUICulture);
                Console.WriteLine(" Managed Thread Id: " + Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("Thread exe context: " + Thread.CurrentThread.ExecutionContext);

                Console.WriteLine("-----------------------------------------------------");


                Thread.Sleep(200);
            }

        }
    }
}
