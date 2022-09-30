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
    public class ExamDAL
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;
        public ExamDAL()
        {
            ds = new DataSet();//in memory cache called DataSet
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["nwndCnStr"].ConnectionString);
        }

        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from Exam", cn);

            //da takes the data from the database using a select query and will disconnect
            //from the database server once it fills/pushes the data to the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "Exam");//disconnect from our database server
                                //Single dataset object can hold multiple tables inside it
                                //To identify each table uniquely we can use a index or name.
                                //index starts with 0, but better to work with name.
            DataTable dt_empdata = ds.Tables["Exam"];
            return dt_empdata;
        }

        public bool InsertEmployee(Exam_BAL employee)
        {
            DataTable dt_empdata = Connect();

            DataRow drow = ds.Tables["Exam"].NewRow();//creates new row in the datatable
                                                      //drow["EmployeeID"] = employee.EmployeeID;
            drow["studid"] = employee.studid;
            drow["examid"] = employee.examid;
            drow["crsid"] = employee.crsid;
            drow["marks"] = employee.marks;


            ds.Tables["Exam"].Rows.Add(drow);// disconnected mode- inthe dataset

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["Exam"]);//record added to the (original)database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;


        }
    }

}
