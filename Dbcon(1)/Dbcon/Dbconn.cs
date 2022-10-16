using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Dbcon
{
    public class Dbconn
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\WatchShop.mdf;Integrated Security=True;Connect Timeout=30");
        public bool UDI(String query)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int c = cmd.ExecuteNonQuery();
                if (c > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(SqlException ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
            //this is to use UDI to use in update insert delete and such queries

        }
        public DataTable Search(String query)
        {
            DataTable dt = null;
            try { 
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                dt = new DataTable();
            adapt.Fill(dt);
            return dt;
            }
            catch(SqlException ex)
            {
                return dt;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
