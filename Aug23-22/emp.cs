using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Structures_functions
{
    internal class emp
    {
        struct Employee
        {
            public int id,deptno;
            public string name;
            public float sal;

            public void getAcceptdata()
            {
                Console.WriteLine("Enter employee id: ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name of employee:");
                name = Console.ReadLine();
                Console.WriteLine("Enter salary:");

                sal = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter dept no:");
                deptno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("-----------------------------------------------");
            }

            public void getDisplaydata(int id,String n,float s,int d)
            {
                Console.WriteLine("Employee Id: " + id);
                Console.WriteLine("Employee name: " + n);
                Console.WriteLine("Employee salary:"+s);
                Console.WriteLine("Employee deptno:"+d);
            }
        }

        
            static void Main(string[] args)
            {

                // declare emp of struct Employee
                Employee emp=new Employee();
                emp.getAcceptdata();
            

            
                emp.getDisplaydata(emp.id,emp.name,emp.sal,emp.deptno);
            
                Console.ReadLine();
            }
        }
    
    /*static void Main(string[] args)
        {

        }*/
    }

