using BL;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {


                

                helperclass p = new helperclass();

                List<BLclass> pr = new List<BLclass>();

                pr = p.Get_Titles();

                foreach (var item in pr)
                {
                    Console.WriteLine(item.Pid);
                    Console.WriteLine(item.PName);
                    Console.WriteLine(item.uprice);
                    Console.WriteLine("-------------------------------");

                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.Read();

        }
    }
}
