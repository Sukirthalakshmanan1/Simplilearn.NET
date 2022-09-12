using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow
{
    internal class Teacher
    {
        private string Name;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        private int std;

        public int Standard
        {
            get { return std; }
            set { std = value; }
        }

        private string section;

        public string Section
        {
            get { return section; }
            set { section = value; }
        }
        private string sub;

        public string Subject
        {
            get { return sub; }
            set { sub = value; }
        }

        public void getdetails()
        {
            Console.WriteLine("Teacher details:");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Enter name of the teacher:");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter class:");
            this.std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter section:");
            this.section = Console.ReadLine();
            Console.WriteLine("Enter subject name taken by teacher:");
            this.sub = Console.ReadLine();
            Console.WriteLine("-----------------------------");
        }
        public void displaydetails()
        {
            Console.WriteLine("Details:");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Teacher name:" + name);
            Console.WriteLine("class:"+std);
            Console.WriteLine("Section:"+section);
            Console.WriteLine("Subject taken by teacher:" +sub);
            Console.WriteLine("-----------------------------");

        }
    }
}
