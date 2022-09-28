using BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALClass1
    {
        public bool InsertEmployee(BookClass e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);

            SqlCommand cmdInsert = new SqlCommand("insert into Book(Book_no,Book_Name,Author,Cost,Category) values(@book_id,@book_name,@book_author,@book_cost,@book_category)", cn);
            cmdInsert.Parameters.AddWithValue("@book_id", e.Book_no);
            cmdInsert.Parameters.AddWithValue("@book_name", e.Bookname);
            cmdInsert.Parameters.AddWithValue("@book_author", e.aName);
            cmdInsert.Parameters.AddWithValue("@book_cost", e.amt);
            cmdInsert.Parameters.AddWithValue("@book_category", e.Category);


           

            cn.Open();
            int i = cmdInsert.ExecuteNonQuery();

            bool status = false;

            if (i == 1)
            {
                status = true;
            }

            cn.Close();//finally
            cn.Dispose();//finally
            return status;



        }
        public bool InsertMember(BookClass employee)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);

            
        SqlCommand cmdInserts = new SqlCommand("insert into Member(Member_id,Member_name) values(@Member_id,@member_name)", cn);
        cmdInserts.Parameters.AddWithValue("@member_id", employee.member_id);
        cmdInserts.Parameters.AddWithValue("@member_name", employee.member_name);


        cn.Open();
        int j = cmdInserts.ExecuteNonQuery();

        bool status = false;

        if (j == 1)
        {
            status = true;
        }

        cn.Close();
        cn.Dispose();
        return status;



    }
        public bool User(BookClass b)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);
            SqlCommand cmdInserts = new SqlCommand("insert into users(userid,password) values(@userid,@password)", cn);
            cmdInserts.Parameters.AddWithValue("@userid", b.userid);
            cmdInserts.Parameters.AddWithValue("@password", b.Password);


            cn.Open();
            int j = cmdInserts.ExecuteNonQuery();

            bool status = false;

            if (j == 1)
            {
                status = true;
            }

            cn.Close();
            cn.Dispose();
            return status;


        }
        public bool Update(BookClass employee)
        {

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);

            SqlCommand cmdUpdate = new SqlCommand("[dbo].[UpdateEmployeeDetails]", cn);

            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;
            cmdUpdate.Parameters.AddWithValue("@p_id1", employee.member_id);
            cmdUpdate.Parameters.AddWithValue("@p_name1", employee.member_name);
            cn.Open();
            int s = cmdUpdate.ExecuteNonQuery();
            bool statusd = false;
            if (s == 1)
            {
                statusd = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return statusd;

        }
        public List<BookClass> EmployeeList()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);

            SqlCommand cmdlist = new SqlCommand("select * from  [dbo].[fn_Emplist]()", cn);
            cn.Open();
            SqlDataReader dr = cmdlist.ExecuteReader();
            List<BookClass> emplist = new List<BookClass>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    BookClass bal = new BookClass();
                    bal.Book_no = Convert.ToInt32(dr["Book_no"]);
                  //  bal.Bookname = (string)dr["Bookname"];
                    bal.Category = dr["category"].ToString();
                   // bal.aName = dr["Author"].ToString();
                    bal.amt = Convert.ToInt32(dr["Cost"]);
                    emplist.Add(bal);
                }
            }
            cn.Close();
            cn.Dispose();
            return emplist;

        }




    }

}

