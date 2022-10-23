using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class Dbcon
    {
        
              SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lovel\OneDrive\Documents\Shop.mdf;Integrated Security=True;Connect Timeout=30");
                
        
        public bool UDI(String query)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            bool c=cmd.ExecuteNonQuery() >0;
            con.Close();
            return c;
        }
        public DataTable Search(String query)
        {
            con.Open();
            SqlDataAdapter adapt=new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
