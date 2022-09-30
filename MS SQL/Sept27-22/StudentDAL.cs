using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BL;

namespace DAL
{
    public class StudentDAL
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;
        public StudentDAL()
        {
            ds = new DataSet();//in memory cache called DataSet
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["nwndCnStr"].ConnectionString);
        }

        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from student", cn);

            //da takes the data from the database using a select query and will disconnect
            //from the database server once it fills/pushes the data to the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "student");//disconnect from our database server
                                   //Single dataset object can hold multiple tables inside it
                                   //To identify each table uniquely we can use a index or name.
                                   //index starts with 0, but better to work with name.
            DataTable dt_empdata = ds.Tables["student"];
            return dt_empdata;
        }

        public int RowCountstudent()
        {
            DataTable dt_empdata = Connect();
            int empcnt = dt_empdata.Rows.Count;
            return empcnt;



        }


        public bool Updatestudent(int empid, Student_BAL employee)
        {
            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["student"].Rows.Find(empid);


            drow["stuid"] = employee.stuid;
            drow["name"] = employee.name;
            drow["crsid"] = employee.crsid;

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["student"]);//record added to the (original)database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;



        }
        public Student_BAL Findstudent(int empid)
        {
            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["student"].Rows.Find(empid);
            Student_BAL emp = new Student_BAL();
            emp.stuid = Convert.ToInt32(drow["stuid"]);
            emp.name = drow["name"].ToString();
            emp.crsid = Convert.ToInt32(drow["crsid"]);


            return emp;



        }


        public List<Student_BAL> ShowAllstudent()
        {
            DataTable dt_empdata = Connect();
            List<Student_BAL> emplist = new List<Student_BAL>();
            for (int i = 0; i < dt_empdata.Rows.Count; i++)
            {
                DataRow drow = dt_empdata.Rows[i];
                Student_BAL emp = new Student_BAL();
                emp.stuid = Convert.ToInt32(drow["stuid"]);
                emp.name = drow["name"].ToString();
                emp.crsid = Convert.ToInt32(drow["crsid"]);

                emplist.Add(emp);

            }
            return emplist;


        }


        public bool Deletestudent(int empid)
        {

            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["student"].Rows.Find(empid);
            drow.Delete();

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["student"]);//record added to the (original)database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;


        }


        public bool Insertstudent(Student_BAL employee)
        {
            DataTable dt_empdata = Connect();

            DataRow drow = ds.Tables["student"].NewRow();//creates new row in the datatable
                                                         //drow["EmployeeID"] = employee.EmployeeID;
            drow["stuid"] = employee.stuid;
            drow["name"] = employee.name;
            drow["crsid"] = employee.crsid;


            ds.Tables["student"].Rows.Add(drow);// disconnected mode- inthe dataset

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["student"]);//record added to the (original)database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;




        }




    }

}
