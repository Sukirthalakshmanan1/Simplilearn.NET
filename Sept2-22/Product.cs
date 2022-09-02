using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //2
    //3 The relation between Category and Products is to be established as 1 Category: M Products.
    public class Product
    {
        private int Pid;

        public int prod_id
        {
            get { return Pid; }
            set { Pid = value; }
        }
        private string pname;

        public string Prod_name
        {
            get { return pname; }
            set { pname = value; }
        }
        private int qtysold;

        public int quantity
        {
            get { return qtysold; }
            set { qtysold = value; }
        }
        private int unitprice;

        public int Price
        {
            get { return unitprice; }
            set { unitprice = value; }
        }

        private int m;

        public int Measurement
        {
            get { return m; }
            set { m = value; }
        }
        private int qty_hand;

        public int Qty_in_hand
        {
            get { return qty_hand; }
            set { qty_hand = value; }
        }

        private int r;

        public int Reorder
        {
            get { return r; } 
            set { r = value; }
        }
        //6
        public void Addproduct(int id, string name,int s,int p,int m1,int ha,int r1)
        {
            
            Pid = id;
            pname = name;
            qtysold = s;
            unitprice= p;
            m = m1;
            qty_hand = ha;
            r = r1;
            
        }
    }
}
