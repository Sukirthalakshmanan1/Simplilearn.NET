using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractlib
{
   public class Employee:Person
    {
        public override void work()
        {
            Console.WriteLine("Employee class !!");
            Console.WriteLine("Enter name:");
            string name=Console.ReadLine();
            Console.WriteLine("Enter id:");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Id:" + i);

            Console.WriteLine("Name of Employee is :"+name);
        }
       
    }
}
