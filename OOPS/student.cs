using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow
{
    internal class student
    {
		private string Name;

		public  string name
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
        public void getdetails()
        {
            Console.WriteLine("Student details:");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Enter name of the student:");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter class:");
            this.std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter section:");
            this.section = Console.ReadLine();
            
            Console.WriteLine("-----------------------------");
        }
        public void displaydetails()
        {
            Console.WriteLine("Details:");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Student name:" + name);
            Console.WriteLine("class:" + std);
            Console.WriteLine("Section:" + section);
            
            Console.WriteLine("-----------------------------");

        }

    }
}
