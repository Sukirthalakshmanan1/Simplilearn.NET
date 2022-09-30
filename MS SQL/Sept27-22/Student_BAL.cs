using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Student_BAL
    {
        private int _stuid;

        public int stuid
        {
            get { return _stuid; }
            set { _stuid = value; }
        }
        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _crsid;

        public int crsid
        {
            get { return _crsid; }
            set { _crsid = value; }
        }


    }

}
