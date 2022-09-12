using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class simple
    {
        private double i;

        public double num1
        {
            get { return i; }
            set { i = value; }
        }

        
        public void cube(double i)
        {
            double a = i * i * i;
            //return a;
            Console.WriteLine("Cube of {0} = {1}",i,a);
        }

        public void sqrt(double i)
        {
            double s = Math.Sqrt(i);
            Console.WriteLine("Sqrt of {0} = {1}",i,s);
        }
    }
}
