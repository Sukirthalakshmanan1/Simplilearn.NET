using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Exam_BAL
    {
        private int _examid;

        public int examid
        {
            get { return _examid; }
            set { _examid = value; }
        }
        private int _crsid;

        public int crsid
        {
            get { return _crsid; }
            set { _crsid = value; }
        }
        private int _studid;

        public int studid
        {
            get { return _studid; }
            set { _studid = value; }
        }

        private int _marks;

        public int marks
        {
            get { return _marks; }
            set { _marks = value; }
        }



    }

}
