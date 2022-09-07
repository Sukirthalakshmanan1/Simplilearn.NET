using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLib
{
	//4
    public class product
    {
        public delegate void product1(int pid,string n);
        private int Pid;

		public int productId
		{
			get { return Pid; }
			set { Pid = value; }
		}
		private string name;

		public string Pname
		{
			get { return name; }
			set { name = value; }
		}
		public void Pro(int p,string s11)
		{
			this.Pid = p;
			this.Pname = s11;
			Console.WriteLine("Id:"+Pid);
			Console.WriteLine("Name: "+Pname);
		}

	}
}
