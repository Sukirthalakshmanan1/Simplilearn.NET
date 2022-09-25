using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLclass
    {
        private string pid;
        public string Pid
        {
            get
            {
                return pid;
            }
            set
            {

                if ((String.IsNullOrEmpty(value)) || (value.Length > 6))
                {
                    throw new Exception("Product id not valid");

                }
                else
                {
                   pid = value;
                }
            }
        }



        private string name;

        public string PName
        {
            get { return name; }
            set
            {
                if ((value.Length > 100) || string.IsNullOrEmpty(value))
                {
                    throw new Exception("Not valid Product name .... Please check");
                }
                else
                {
                    name = value;
                }

            }
        }



        private string price;

        public string uprice
        {
            get { return price; }
            set
            {
                if (value.Length > 10)
                {
                    throw new Exception("Length of price cannot be more than 10 digits !!");
                }
                else
                {
                   price= value;
                }

            }
        }
    }
}
