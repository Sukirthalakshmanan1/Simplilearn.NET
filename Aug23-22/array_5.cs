using System;

namespace Structures_functions
{
    internal class array_5
    {
       

        struct Employee
        {
            public int id, deptno;
            public string n;
            public float sal;

            public void acceptdata()
            {
                
                    Console.WriteLine("Enter employee id: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter name of employee:");
                    n = Console.ReadLine();
                    Console.WriteLine("Enter salary:");

                    sal = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Enter dept no:");
                    deptno = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("-----------------------------------------------");
                
            }
            public void getDisplaydata()
            {
                Console.WriteLine("Employee Id: " + id);
                Console.WriteLine("Employee name: " + n);
                Console.WriteLine("Employee salary:" + sal);
                Console.WriteLine("Employee deptno:" + deptno);
            }

        }
        static void Main(string[] args)
        {
            Employee[] a = new Employee[5];
            Employee e =new Employee();
            Console.WriteLine("Enter no of students details to be entered: ");
            int n= Convert.ToInt32(Console.ReadLine());
            //emp[] arr= new emp[2];

            /*for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter employee id: ");
                e.id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name of employee:");
                e.n = Console.ReadLine();
                Console.WriteLine("Enter salary:");

                e.sal = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter dept no:");
                e.deptno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("-----------------------------------------------");
            }*/

            for (int i = 0; i < n; i++)
            {
                a[i].acceptdata();
            
            }
                for (int i=0; i < n; i++)
            {
                a[i].getDisplaydata();
            }
                Console.ReadLine();
        }
    }
}
