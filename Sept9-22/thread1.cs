using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_pgms
{
    public class thread1
    {
        public void M1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Thread method 1 =   {0} ", i);
                if (i == 5)
                {
                    Thread.Sleep(5000);
                }
            }
        }
        public void m2(object n)
        {
            int num = 0;
            if(int.TryParse(n.ToString(),out num)){
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Number = {0}", i);
                } }
        }
    }
}
