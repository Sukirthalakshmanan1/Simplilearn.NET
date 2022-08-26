using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_lib
{
   public class Class_stud
    {
        public int id;
        public string Name;
        public int Age;
        public double m;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string SName
        {
            get { return Name; }
            set { Name = value; }
        }
        public int age
        {
            get { return Age; }
            set { Age = value; }
        }
        public double marks
        {
            get { return m; }
            set { m = value; }
        }
    }
}
