using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_functions
{
    internal class emp_3
    {
        struct Employee
        {
            public int id,deptno;
            public string n;
            public float sal;

            // creates property
            public int Id
            {

                // returns id field
                get
                {
                    return id;
                }

                // sets id field
                set
                {
                   // if (value != 0) { id = value; }
                    id = value;
                }
            }
            public string name
            {
                get
                {
                    return n;
                }
                set { n = value; }
            }
        }
        static void Main(string[] args)
        {
            Employee e=new Employee();
            Console.WriteLine("Enter employee id: ");
            e.Id = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("Enter name of employee:");
            e.name = Console.ReadLine();
            

            Console.WriteLine("Enter salary:");

            e.sal = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("Enter dept no:");
            e.deptno = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Employee Id: " + e.Id);

            Console.WriteLine("Employee name: " + e.name);
            Console.WriteLine("Employee Salary: " + e.sal);

            Console.WriteLine("Employee Dept num: " + e.deptno);

            Console.ReadLine();



        }
}
}
