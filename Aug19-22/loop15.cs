using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_firstpgm
{
    internal class loop15
    {
        static void Main(string[] args)
        {
            for (int i = 0, j = 25; i < j; i++, j--)
            {
                Console.WriteLine("i ={0} and j = {1}", i, j);
            }
            Console.WriteLine("Crossed Over !! ");
            Console.ReadLine();

        }
    }
}
