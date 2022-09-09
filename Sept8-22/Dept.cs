using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Lib_1.Dept;

namespace Lib_1
{
    
    public delegate void DEventHandler(List<Employee1> list);
    public delegate void D1EventHandler(int Empid,List<Employee1> list);

    //1
    public class Dept
    {
        //3
        static int count = 0;
        private List<Employee1> l;
        public List<Employee1> product1
        {
            get { return l; }
            set { l = value; }
        }

        private int no;

        public int deptno
        {
            get { return no; }
            set { no = value; }
        }

        private string dname;

        public string deptname
        {
            get { return dname; }
            set { dname = value; }

        }

        private string loc;

        public string Location
        {
            get { return loc; }
            set { loc = value; }
        }
        public static event DEventHandler add;
        public static event DEventHandler modify;

        //4
        public void add1(List<Employee1> list)
        {

            Console.WriteLine("Enter no of depts:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < n1; j++)
            {
                Console.WriteLine("Enter dept no:");
                deptno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter no of employees to be added:");
                int n = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < n; i++)
                {
                    if (count < 10)
                    {


                        list.Add(new Employee1());



                        Console.WriteLine("Enter employee id:");
                        list[i].Id = Convert.ToInt32(Console.ReadLine());
                        count++;
                        Console.WriteLine("Enter name:");
                        list[i].Empname = Console.ReadLine();
                       
                        //list[i].Departmentno = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Enter salary:");
                        list[i].salary = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter manager id:");
                        list[i].ManagerId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter manager name:");
                        list[i].Managername = Console.ReadLine();

                        Console.WriteLine("Added Successfully !!");
                        Console.WriteLine("No of employees in dept:" + count);
                        Console.WriteLine("---------------------------------");

                    }
                    else
                    {
                        Console.WriteLine("Employee cannot be added !! ");
                        Console.WriteLine("------------------------------");
                    }
                }
            }

        }

        public  void remove_emp(List<Employee1> list)
        {
            Console.WriteLine("Enter employee id to be deleted:");
            int a = Convert.ToInt32(Console.ReadLine());
           Employee1 p = list.Find(item => item.Id == a);
            //isTeenAger ager2 = (s) => { return s.Age >= 13 && s.Age <= 19; };
            if (true)
            {
                list.Remove(p);
                Console.WriteLine("Removed Successfully!!");
            }
            else
            {
                Console.WriteLine("Item not found !!");
            }
            Console.WriteLine("------------------------------");


        }

        

        public  void UpdateList(List<Employee1> list)
        {
            Console.WriteLine("Emter employee id to update :");
            int s = Convert.ToInt32(Console.ReadLine());
            var result = from r in list where r.Id == s select r;
            Console.WriteLine("Enter the empname to update:");
            string aa = Console.ReadLine();
            result.First().Empname = aa;
            Console.WriteLine("The list is updated !!");
            Console.WriteLine("------------------------------");
        }

        
            public void Edit(List<Employee1> ls)
            {
            Console.WriteLine("Enter emp id:");
            int EmpId=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select to modify:\n 1.Empname\n 2.Salary\n 3.Manager");
                int f = Convert.ToInt32(Console.ReadLine());
                switch (f)
                {
                    case 1:
                        foreach (var item in ls)
                        {
                            if (item.Id == EmpId)
                            {

                                Console.WriteLine("Enter the new name to modify:");
                                item.Empname = Console.ReadLine();

                            }
                        }

                        break;

                    case 2:
                        foreach (var item in ls)
                        {
                            if (item.Id == EmpId)
                            {

                                Console.WriteLine("Enter the salary to modify :");
                                item.salary = Convert.ToInt32(Console.ReadLine());

                            }
                        }

                        break;
                    case 3:
                        foreach (var item in ls)
                        {
                            if (item.Id == EmpId)
                            {

                                Console.WriteLine("Enter the new manager name to modify: ");
                                item.Managername = Console.ReadLine();


                            }
                        }

                        break;
                    
                }

                
            }
        //6
        public void displaybymgr(List<Employee1> list)
        {
            Console.WriteLine("Enter the name of the manager to list employees working under him/her: ");
            string s = Console.ReadLine();
            var aw = list.Where(i => i.Managername == s).ToList();
            if (aw.Count > 0)
            {
                Console.WriteLine("List:");
                foreach (var item in aw)
                {
                    
                    Console.WriteLine(item.Empname);
                }
            }
            else
            {
                Console.WriteLine("No employee is working under him/her !!");
            }
        }

        //7

        public void login(List<Employee1> list)
        {
            Console.WriteLine("Enter userid:");
            string uid=Console.ReadLine();
            Console.WriteLine("Enter password:");
            string pass=Console.ReadLine();
            foreach(var item in list)
            {
                if (uid == item.Empname && pass=="Password")
                {
                    Console.WriteLine("Login successful !! Welcome "+item.Empname);
                }
               
               
            }

        }
        //5
        public void disp(List<Employee1> list)
        {

            foreach (var item in list)
            {
                Console.WriteLine("Employee details:");
                Console.WriteLine("Emp Id:" + item.Id);
                Console.WriteLine("Employee Name:" + item.Empname);
                Console.WriteLine("Dept no  :" + deptno);
                Console.WriteLine("Salary:"+item.salary);
                Console.WriteLine("Manager id:"+item.ManagerId);
                Console.WriteLine("Manager name:" + item.Managername);

                Console.WriteLine("------------------------------");

            }
           

        }

    }
}
