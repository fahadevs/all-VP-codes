using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchShop
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
            DisplayData();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lovel\OneDrive\Documents\WatchShop.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int Id = 0;
        String findgender()
        {
            String Name = User.name.ToString();
            String gender;
            cmd = con.CreateCommand();
            cmd.CommandText = "select gender from users where username='" + Name + "'";
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader(); dr.Read();
            gender = dr["gender"].ToString();


            /*SqlDataReader productsSqlDataReader = cmd.ExecuteReader();
            int genderNameColPos = productsSqlDataReader.GetOrdinal("gender");
            /*string gender = productsSqlDataReader.GetString(genderNameColPos);*/
            /*cmd.ExecuteNonQuery();
            adapt = cmd;*/
            /*while (productsSqlDataReader.Read())
            {
                gender = productsSqlDataReader.GetString(genderNameColPos);
            }
            productsSqlDataReader.Close();*/
            con.Close();
            return gender;
        }
        private void DisplayData()
        {
            String gender1 = findgender();
            con.Open();
            //String name = User.SetValueForText1.ToString();
            /*cmd = new SqlCommand("select gender from users where username=@name",con);
            cmd.Parameters.AddWithValue("@name",User.SetValueForText1);
            SqlDataReader da = cmd.ExecuteReader();
            while(da.Read())
            {
                String gender = da.GetValue(0).ToString();
            }
            con.Close();*/
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select brand,price from watches where gender='"+gender1+"'", con);
            //String gender = adapt.ToString();
            //cmd.Parameters.AddWithValue("@gender","male");
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String gender = findgender();  
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select brand,price from watches where brand='"+textBox3.Text+"'AND gender='"+gender+"'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    }
}
