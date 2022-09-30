using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CourseBAL
    {
        private int _courseid;

        public int courseid
        {
            get { return _courseid; }
            set { _courseid = value; }
        }

        private string _coursename;

        public string coursename
        {
            //20
            get { return _coursename; }
            set { _coursename = value; }
        }



        private string _deptid;

        public string deptid
        {

            get { return _deptid; }
            set
            {

                _deptid = value;


            }
        }

        private int _duration;

        public int duration
        {
            //30
            get { return _duration; }
            set { _duration = value; }
        }


    }

}
