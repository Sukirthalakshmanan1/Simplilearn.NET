using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm2
{
    internal class Program
    {

//pbm stmt 3
        static void Main(string[] args)
        {
            double i,j,res;
            Console.WriteLine("Enter two numbers:");
            i= Convert.ToInt32(Console.ReadLine());
            j= Convert.ToInt32(Console.ReadLine());
             res=i+j;
            Console.WriteLine("{0}+{1} ={2}",i,j,res);
            res=i-j;
            Console.WriteLine("{0}-{1} ={2}",i,j,res);
            res=i*j;
            Console.WriteLine("{0}*{1} ={2}",i,j,res);
            res=i/j;
            Console.WriteLine("{0}/{1} ={2}",i,j,res);
            Console.ReadKey();
        }
}
}