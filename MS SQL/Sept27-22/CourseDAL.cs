using BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CourseDAL
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;
        public CourseDAL()
        {
            ds = new DataSet();//in memory cache called DataSet
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["nwndCnStr"].ConnectionString);
        }

        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from course", cn);

            //da takes the data from the database using a select query and will disconnect
            //from the database server once it fills/pushes the data to the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "course");//disconnect from our database server
                                  //Single dataset object can hold multiple tables inside it
                                  //To identify each table uniquely we can use a index or name.
                                  //index starts with 0, but better to work with name.
            DataTable dt_empdata = ds.Tables["course"];
            return dt_empdata;
        }

        public int RowCountcourse()
        {
            DataTable dt_empdata = Connect();
            int empcnt = dt_empdata.Rows.Count;
            return empcnt;



        }


        public bool UpdateCourse(int cid, CourseBAL employee)
        {
            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["course"].Rows.Find(cid);


            drow["courseid"] = employee.courseid;
            drow["coursename"] = employee.coursename;
            drow["duration"] = employee.duration;
            drow["deptid"] = employee.deptid;

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["course"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;



        }
        public CourseBAL FindCourse(int empid)
        {
            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["course"].Rows.Find(empid);
            CourseBAL emp = new CourseBAL();
            emp.courseid = Convert.ToInt32(drow["courseid"]);
            emp.coursename = drow["coursename"].ToString();
            emp.duration = Convert.ToInt32(drow["duration"]);
            emp.deptid = drow["deptid"].ToString();

            return emp;



        }


        public List<CourseBAL> ShowAllcourse()
        {
            DataTable dt_empdata = Connect();
            List<CourseBAL> emplist = new List<CourseBAL>();
            for (int i = 0; i < dt_empdata.Rows.Count; i++)
            {
                DataRow drow = dt_empdata.Rows[i];
                CourseBAL emp = new CourseBAL();
                emp.courseid = Convert.ToInt32(drow["courseid"]);
                emp.coursename = drow["coursename"].ToString();
                emp.duration = Convert.ToInt32(drow["duration"]);
                emp.deptid = drow["deptid"].ToString();
                emplist.Add(emp);

            }
            return emplist;


        }


        public bool Deletecourse(int empid)
        {

            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["course"].Rows.Find(empid);
            drow.Delete();

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["course"]);//record added to the (original)database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;


        }


        public bool Insertcourse(CourseBAL employee)
        {
            DataTable dt_empdata = Connect();

            DataRow drow = ds.Tables["course"].NewRow();//creates new row in the datatable
                                                        //drow["EmployeeID"] = employee.EmployeeID;
            drow["courseid"] = employee.courseid;
            drow["coursename"] = employee.coursename;
            drow["duration"] = employee.duration;
            drow["deptid"] = employee.deptid;

            ds.Tables["course"].Rows.Add(drow);// disconnected mode- inthe dataset

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["course"]);//record added to the (original)database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;




        }




    }

}
