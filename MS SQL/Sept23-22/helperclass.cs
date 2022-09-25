using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class helperclass
    {
        public List<BLclass> Get_Titles()
        {
            DALclass titles = new DALclass();
            List<BLclass> booksList = new List<BLclass>();
            booksList = titles.productlist();
            return booksList;


        }

    }
}
