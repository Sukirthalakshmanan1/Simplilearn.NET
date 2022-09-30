using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class CourseHelper
    {
        CourseDAL dal = null;
        public CourseHelper()
        {
            dal = new CourseDAL();
        }


        public int RowCountcourse()
        {
            return dal.RowCountcourse();

        }
        public bool AddNewcourse(CourseBAL employee)
        {
            return dal.Insertcourse(employee);
        }
        public CourseBAL Locatecourse(int empid)
        {
            return dal.FindCourse(empid);
        }

        public List<CourseBAL> courseList()
        {
            return dal.ShowAllcourse();
        }

        public bool RemovecourseData(int empid)
        {
            return dal.Deletecourse(empid);
        }



        public bool EditCourseData(int empid, CourseBAL employee)
        {
            return dal.UpdateCourse(empid, employee);
        }

    }

}
