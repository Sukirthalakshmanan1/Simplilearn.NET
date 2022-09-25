using BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALclass
    {
        public List<BLclass> productlist()
        {

            string connectionString = "Data Source=DESKTOP-5GL4B5D\\SQLEXPRESS1;Initial Catalog=Northwind;Integrated Security=True";

            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from Products", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<BLclass> prod = new List<BLclass>();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    BLclass title = new BLclass();
                    title.Pid = dr[0].ToString();
                    title.PName = dr[1].ToString();
                    title.uprice = dr["UnitPrice"].ToString();

                    prod.Add(title);

                }
            }
            else
            {
                Console.WriteLine("No products found");
            }
            cn.Close();
            return prod;
                
           
        }
    }
}
