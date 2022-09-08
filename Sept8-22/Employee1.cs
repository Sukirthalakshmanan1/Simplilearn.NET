using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_1
{
     // public delegate void DEventHandler(List<Employee1> list);
        public class Employee1
        {
            private int empid;

            public int Id
            {
                get { return empid; }
                set { empid = value; }
            }

            private string name;

            public string Empname
            {
                get { return name; }
                set { name = value; }
            }
        private string Mname;

        public string Managername
        {
            get { return Mname; }
            set { Mname = value; }
        }

        private int deptno;

            public int Departmentno
            {
                get { return deptno; }
                set { deptno = value; }
            }
            private float sal;
            public float salary
            {
                get { return sal; }
                set { sal = value; }
            }

            private int mgr;

            public int ManagerId
            {
                get { return mgr; }
                set { mgr = value; }
            }

            public void details()
            {


                Console.WriteLine("Employee details:");

                Console.WriteLine("Enter id: ");
                this.empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name:");
                this.name = Console.ReadLine();
                Console.WriteLine("Enter dept no:");
                this.deptno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter salary:");
                this.sal = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter manager id:");
                this.mgr = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("---------------------------------");
                Console.WriteLine("Employee Id:" + empid);
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Deptno:" + deptno);
                Console.WriteLine("Salary:" + sal);
                Console.WriteLine("Manager id : " + mgr);
            }
           /* public static event DEventHandler add;

            public void add1(List<Employee1> list)
            {



                Console.WriteLine("Enter employee id:");
                this.empid = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter name:");
                this.name = Console.ReadLine();
                Console.WriteLine("Enter dept no:");
                this.deptno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter salary:");
                this.sal = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter manager id:");
                this.mgr = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Employee Id:" + empid);
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Deptno:" + deptno);
                Console.WriteLine("Salary:" + sal);
                Console.WriteLine("Manager id : " + mgr);

            }
           */
        }
    }
