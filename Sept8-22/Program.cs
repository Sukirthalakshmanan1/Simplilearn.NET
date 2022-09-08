using Lib_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_pgm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dept d = new Dept();
            Employee1 e = new Employee1();
            List<Employee1> list = new List<Employee1>();
            char c;
            Console.WriteLine(" ## Details ##");
            Console.WriteLine("------------------------------------");
            do
            {
                Console.WriteLine("Enter your choice: \n 1.Add \n 2.Remove \n 3.Display all details  \n 4.Edit and Update \n 5.Display by manager name");

                int n =Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Dept.add += new DEventHandler(d.add1);
                    
                    d.add1(list);
                    Dept.add += new DEventHandler(d.disp);
                        d.disp(list);
                    break;
                 case 2:
                        Dept.add += new DEventHandler(d.remove_emp);
                        d.remove_emp(list);
                        Dept.add += new DEventHandler(d.disp);
                        d.disp(list);
                        
                        break;
                    case 3:
                        Dept.add += new DEventHandler(d.disp);
                        d.disp(list);
                        break;

                    case 4:
                        Dept.add += new DEventHandler(d.Edit);
                        d.Edit(list);
                        d.disp(list);
                        break;
                    case 5:
                        Dept.add += new DEventHandler(d.displaybymgr);
                        d.displaybymgr(list);
                        break;
                }
                Console.WriteLine("Do u want to continue press y or Y:");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'y' || c == 'Y');
            //e.details();

            /*Console.WriteLine("Now the time = ");
            Action action = () => Console.WriteLine(DateTime.Now.ToLongTimeString());
            action();*/

            Console.ReadLine();

        }
    }
}
