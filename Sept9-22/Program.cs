using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_pgms
{
    public class Program
    {
        
        static void Main(string[] args)
        {
           //M1();
            /*Thread t = new Thread(M1);
            t.Start();*/

            //1

            thread1 t=new thread1();
            Thread t3 = new Thread(new ThreadStart(t.M1));
            //t3.Start();

            Console.WriteLine("Enter numbers to be printed :");
            object n = Console.ReadLine();
            ParameterizedThreadStart start = new ParameterizedThreadStart(t.m2);
            Thread T1 = new Thread(start);
           // T1.Start(n);


            //2
            nameproperty obj = new nameproperty();
            Thread T2 = new Thread(new ThreadStart(obj.M2));
           // T2.Start();
            T2.Name = "Thread name property";

            //3
            T1.Priority = ThreadPriority.Highest;
            t3.Priority = ThreadPriority.Normal;
            T2.Priority = ThreadPriority.Lowest;
           
            T1.Start(n);
            t3.Start();
            T2.Start();
            Console.WriteLine("---------------------------------------");
           
            //4 monitor
            for (int i = 0; i < 2; i++)
            {
                monitor m = new monitor();
                Thread s = new Thread(m.display);
                s.Name = string.Concat("Monitor class Thread : ", i);
                s.Start();

            }
            t3.Abort();

            

          
            Console.ReadKey();
        }
    }
}
