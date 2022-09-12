using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow
{
    internal class Program
    {
        static void Main(string[] args)
        {
             student s=new student();
            s.getdetails();
            s.displaydetails();
            Teacher t=new Teacher();
            t.getdetails();
            t.displaydetails();
            subject ss = new subject();
            ss.getdetails();
            ss.displaydetails();
            Console.ReadLine();
        }
    }
}
