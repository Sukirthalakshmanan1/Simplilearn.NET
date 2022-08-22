using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_firstpgm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,max,min;
            

           
            Console.Write("Enter First number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second number: ");
            n2= Convert.ToInt32(Console.ReadLine());

            //To find max number :
            if (n1 > n2)
                max = n1;
            else
                max = n2;

            //To find min number 
            if (n1 < n2)
                min = n1;
            else
                min = n2;

            
            Console.WriteLine("Minimum number is {0}", min);
            Console.WriteLine("Maximum number is {0}", max);

            
           
            Console.ReadLine();
        }
    }
}
