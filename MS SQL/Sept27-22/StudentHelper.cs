using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    
        public class StudentHelper
        {
            StudentDAL dal = null;
            public StudentHelper()
            {
                dal = new StudentDAL();
            }


            public int RowCountStudent()
            {
                return dal.RowCountstudent();

            }
            public bool AddNewStudent(Student_BAL employee)
            {
                return dal.Insertstudent(employee);
            }
            public Student_BAL Locatestudent(int empid)
            {
                return dal.Findstudent(empid);
            }

            public List<Student_BAL> SList()
            {
                return dal.ShowAllstudent();
            }

            public bool RemoveStudentData(int empid)
            {
                return dal.Deletestudent(empid);
            }



            public bool EditStudentData(int empid, Student_BAL employee)
            {
                return dal.Updatestudent(empid, employee);
            }

        }
    }


