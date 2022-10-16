using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Dbcon
{
    public partial class Form1 : Form
    {
        Dbconn db = new Dbconn();
        public Form1()
        {
            InitializeComponent();
            Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string CellNum = textBox2.Text;
            string Address = textBox3.Text;
            string query = "INSERT INTO watches VALUES('" + Name + "','" + CellNum + "','" + Address + "')";

            
                Dbconn db = new Dbconn();
                if (db.UDI(query) == true)
                {
                    MessageBox.Show("Record Inserted Successfully");
                Display();
                }
                else
                {
                    MessageBox.Show("Record NOT Inserted ");
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string CellNum = textBox2.Text;
            string Address = textBox3.Text;
            string query = "Update watches set  price='" + CellNum + "', gender='" + Address + "' where brand='" + Name + "'";


            
            if (db.UDI(query) == true)
            {
                MessageBox.Show("Record Updated Successfully");
                Display();
            }
            else
            {
                MessageBox.Show("Record NOT Inserted ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string CellNum = textBox2.Text;
            string Address = textBox3.Text;
            string query = "Delete from watches where brand='" + Name + "'";


            Dbconn db = new Dbconn();
            if (db.UDI(query) == true)
            {
                MessageBox.Show("Record Deleted Successfully");
                Display();
            }
            else
            {
                MessageBox.Show("Record NOT Inserted ");
            }
        }
        public void Display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\WatchShop.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter adapt = new SqlDataAdapter("Select * from watches", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String query = "Select * from watches where Id="+Int32.Parse(textBox1.Text)+"";
            DataTable dt = db.Search(query);
            if(dt!=null)
            {
                textBox1.Text = dt.Rows[0][1].ToString();
                textBox2.Text = dt.Rows[0]["price"].ToString();
                textBox3.Text = dt.Rows[0]["gender"].ToString();
            }
            else
            {
                MessageBox.Show("no data found");
            }
        }
    }
}
