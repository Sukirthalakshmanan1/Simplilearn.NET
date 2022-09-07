using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLib
{
	//5
    public class Employee
    {
        public delegate void calc(int y);
        private int year;

		public int DOJ
		{
			get { return year; }
			set { year = value; }
		}
		public void method(int doj)
		{
			
            string currentYear = DateTime.Now.Year.ToString();
            int result = Int32.Parse(currentYear);
            Console.WriteLine("Current year :"+result);
			int experience = result - doj;
			Console.WriteLine("Experience gained is:"+experience);
			
        }
	}
}
