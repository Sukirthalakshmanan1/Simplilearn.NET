using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_pgms
{
    //4
    internal class simple_mutex
    {
        private static int runs = 0;
        static Mutex mutex = new Mutex(false, "RunsMutex");
       public static void Count()
        {
            while (runs < 10)
            {
                
                mutex.WaitOne();
                int Temp = runs;
                Temp++;
                Console.WriteLine(Thread.CurrentThread.Name + " " + Temp);
                Thread.Sleep(800);
                runs = Temp;
                 
                mutex.ReleaseMutex();
            }
        }
        static void Main(string[] args)
        {
             using (Mutex mutex = new Mutex(false, "Mutex Thread !!"))
             {

                 if (!mutex.WaitOne(5000, false))
                 {
                     Console.WriteLine("Already running in another console....");
                     Console.ReadLine();
                     return;

                 }
                 else
                 {
                     Console.WriteLine("App is running in a console....");
                     Console.ReadLine();
                 }

             }
            Console.WriteLine("----Numbers-----");
            Thread t2 = new Thread(new ThreadStart(Count));
            t2.Name = "T2";
            Thread t3 = new Thread(new ThreadStart(Count));
            t3.Name = "T3";
            t2.Start();
            t3.Start();
            Console.Read();



        }
    }
}
