using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{

    public class BookClass
    {
        private int Bookno;

        public int Book_no
        {
            get { return Bookno; }
            set { Bookno = value; }
        }

        private string bname;

        public string Bookname
        {
            //30
            get { return bname; }
            set { bname = value; }
        }



        private string author;

        public string aName
        {

            get { return author; }
            set
            {
                if ((value.Length > 10) || (string.IsNullOrEmpty(value)))
                {
                    throw new Exception("Author Name too long.. it shud not exceed 30 chars");
                }
                else
                {
                    author = value;
                }

            }
        }

        private float cost;
        public float amt
        {
            get { return cost; }
            set { cost = value; }
        }

        private string c;

        public string Category
        {
            //10
            get { return c; }
            set { c = value; }
        }

        private int _memberid;

        public int member_id
        {
            get { return _memberid; }
            set { _memberid = value; }
        }
        private string _membername;

        public string member_name
        {
            get { return _membername; }
            set { _membername = value; }
        }


        private string uid;

        public string userid
        {
            //30
            get { return uid; }
            /*set
            {
                if ((value.Length > 10) || (string.IsNullOrEmpty(value)))
                {
                    throw new Exception("Userid  incorrect");
                }
                else
                {
                    pass = value;
                }

            }*/
            set { uid = value; }

        }

        private string pass;

        public string Password
        {
           
            get { return pass; }
            set
            {
                if ((value.Length > 20) || (string.IsNullOrEmpty(value)) || value!="Suki@123")
                {
                    throw new Exception("Password too long.. it shud not exceed 20 chars");
                }
                else
                {
                    pass = value;
                }

            }

            //set { pass = value; }
        }
       
}
}
