using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booklib
{
    public class Book_category
    {
		private int catid;

		public int Cat_Id
		{
			get { return catid; }
			set { catid = value; }
		}
        private string catname;

        public string Cat_Name
        {
            get { return catname; }
            set { catname = value; }
        }

        private string d;

        public string desc
        {
            get { return d; }
            set { d = value; }
        }
        public Book_category()
        {
            Console.WriteLine("Hello book category !! Default constructor called !!");
            Console.WriteLine("--------------------------------");

        }

        public Book_category(int catid,  string catname,  string d)
        {
            Console.WriteLine("Parameterized constructor called in class Book category !!");
            Console.WriteLine("--------------------------------");

            this.catid = catid;
            
            this.catname = catname;
           
            this.d = d;
            
            Console.WriteLine("Id:"+catid+" \n" + "Name: "+catname+"\n"+ "Description:"+d);
            Console.WriteLine("--------------------------------");

        }

    }
}
