using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace OfcMgtSystem
{
    public class DbOffice
    {
        public static SqlConnection getconnection()
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\student\Documents\Office.mdf;Integrated Security=True;Connect Timeout=30");
                return con;
            }
        public  void  Insert(Office ofc)
            {
            
                string query = "INSERT INTO Employeetbl VALUES(@name,@cellnum,@address)";
            SqlConnection con = getconnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", ofc.empname);
            cmd.Parameters.AddWithValue("@cellnum", ofc.empcellnum);
            cmd.Parameters.AddWithValue("@name", ofc.empaddress);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public  void Update(Office ofc,int id)
        {

            string query = "Update Employeetbl set name='"+ofc.empname+ "', cellnum='" + ofc.empcellnum + "',address='" + ofc.empaddress+ "'";
            SqlConnection con = getconnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Delete(int id)
        {

            string query = "Delete from Employeetbl where Id='"+id+"'";
            SqlConnection con = getconnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Display(String query,DataGridView gv)
        {
            String sql = query;
            SqlConnection con = getconnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close(); 
        }
    }
}
