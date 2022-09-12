using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow
{
    internal class subject
    {
        private string Name;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        private int code;

        public int subcode

        {
            get { return code; }
            set { code = value; }
        }

        private string Teacher; 

        public string T
        {
            get { return Teacher; }
            set { Teacher = value; }
        }


        private List<Teacher> l;
        public List<Teacher> t

        {
            get { return l; }
            set { l = value; }
        }


        private List<student> s;
        public List<student> stud
        {
            get { return s; }
            set { s = value; }
        }

        public void getdetails()
        {
            Console.WriteLine("Subject details:");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Enter name of subject:");
            this.name=Console.ReadLine();
            Console.WriteLine("Enter subject code:");
            this.subcode=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------");
        }
        public void displaydetails()
        {
            Console.WriteLine("Details of Subjects:");
            Console.WriteLine("-----------------------------");

            Console.WriteLine( "Subject name:"+name);
            Console.WriteLine("Subject code:"+subcode);
            Console.WriteLine("-----------------------------");

        }

        }
}
