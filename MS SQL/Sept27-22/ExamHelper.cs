using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class ExamHelper
    {
        ExamDAL dal = null;
        public ExamHelper()
        {
            dal = new ExamDAL();
        }
        public bool AddNewExam(Exam_BAL employee)
        {
            return dal.InsertEmployee(employee);
        }

    }

}
