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

namespace Dbcon
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            Display();
        }
        Dbconn db = new Dbconn();
        public void Display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lovel\OneDrive\Documents\Shop.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter adapt = new SqlDataAdapter("Select * from Customers", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void CustomersForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Cell = textBox2.Text;
            string Address = textBox3.Text;
            string query = "INSERT INTO Customers VALUES('" + Name + "','" + Cell + "','" + Address + "')";



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
            string Quantity = textBox2.Text;
            string Price = textBox3.Text;
            int Id = int.Parse(textBox4.Text);
            string query = "Update Customers set  CustomerName='" + Name + "', CustomerCell='" + Quantity + "' , CustomerAddress='" + Price + "' where Id='" + Id + "'";



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
            string query = "Delete from Customers where Id='" + Id + "'";


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

        private void button4_Click(object sender, EventArgs e)
        {
            String query = "Select * from Customers where Id=" + Int32.Parse(textBox4.Text) + "";
            DataTable dt = db.Search(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                textBox1.Text = dt.Rows[0][1].ToString();
                textBox2.Text = dt.Rows[0][2].ToString();
                textBox3.Text = dt.Rows[0][3].ToString();
                textBox4.Text = dt.Rows[0][0].ToString();

            }
            else
            {
                MessageBox.Show("no data found");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Close();
        }
    }
}
