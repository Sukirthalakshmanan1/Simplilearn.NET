using new_lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of details to be entered:");
            int n = Convert.ToInt32(Console.ReadLine());
            student[] s = new student[n];
            Console.WriteLine("Student Details:");
           
            //Class_stud[] s = new Class_stud[n];
            for (int i = 0; i < n; i++)
            {
                 s[i] = new student();
                //s[i]=new Class_stud();

                Console.WriteLine("Enter Roll no:");
                s[i].Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name:");
                s[i].SName = Console.ReadLine();
                Console.WriteLine("Enter Age:");
                s[i].age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Marks:");
                s[i].m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------------------------------");


            }
            foreach (var item in s)
            {
                Console.WriteLine("Following are the details:");
                Console.WriteLine("Roll no : "+item.Id);
                Console.WriteLine("Student name:"+item.SName);
                Console.WriteLine("Student age:"+item.age);
                Console.WriteLine("Marks:"+item.m);
               
                

            }
            Console.ReadLine();
        }
    }
}
