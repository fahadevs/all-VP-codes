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
            string query = "INSERT INTO Employees VALUES('" + Name + "','" + CellNum + "','" + Address + "')";

            
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
            int Id = int.Parse(textBox4.Text);
            string Name = textBox1.Text;
            string CellNum = textBox2.Text;
            string Address = textBox3.Text;
            string query = "Update Employees set  EmpName='" + Name+ "', EmpCell='" + CellNum + "' , EmpAddress='" + Address + "' where EmpId='" + Id+ "'";


            
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
            int Id = int.Parse(textBox4.Text);
            string query = "Delete from Employees where EmpId='" + Id+ "'";


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
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lovel\OneDrive\Documents\Shop.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter adapt = new SqlDataAdapter("Select * from Employees", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String query = "Select * from Employees where EmpId="+Int32.Parse(textBox4.Text)+"";
            DataTable dt = db.Search(query);
            if(dt!=null && dt.Rows.Count>0)
            {
                textBox1.Text = dt.Rows[0][1].ToString();
                textBox2.Text = dt.Rows[0]["EmpCell"].ToString();
                textBox3.Text = dt.Rows[0]["EmpAddress"].ToString();
                textBox4.Text = dt.Rows[0]["EmpId"].ToString();

            }
            else
            {
                MessageBox.Show("no data found");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Close();
        }
    }
}
