using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class Helperclass1
    {




        DALClass1 dal = null;
        public Helperclass1()
        {
            dal = new DALClass1();
        }
        public bool Editmember(BookClass b)
        {
            return dal.Update(b);

        }
        public bool Adduser(BookClass b)
        {
            return dal.User(b);

        }
        public bool AddBook(BookClass b)
        {
            return dal.InsertEmployee(b);

        }

        public bool AddMember(BookClass b)
        {
            return dal.InsertMember(b);

        }

        public List<BookClass> ShowEmployeeList()
        {
            return dal.EmployeeList();
        }

    }
    }
