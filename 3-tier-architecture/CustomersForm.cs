using AppProps;
using BuisnessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_tier_architecture
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            Display();
        }
        public void Display()
        {
            DataTable dt = new DataTable();
            dt = new CustomersBll().SearchCustomersBll();
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Customers emp = new Customers();
            emp.Customersname = textBox1.Text;
            emp.Customerscell = textBox2.Text;
            emp.Customersaddress = textBox3.Text;
            CustomersBll empbll = new CustomersBll();
            bool c = empbll.AddCustomersBll(emp);
            if (c == true)
            {
                MessageBox.Show("success");
                Display();
            }
            else
            {
                MessageBox.Show("failed");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customers emp = new Customers();
            emp.Customersname = textBox1.Text;
            emp.Customerscell = textBox2.Text;
            emp.Customersaddress = textBox3.Text;
            emp.Id = int.Parse(textBox5.Text);
            CustomersBll empbll = new CustomersBll();
            bool c = empbll.UpdateCustomersBll(emp);
            if (c == true)
            {
                MessageBox.Show("success");
                Display();
            }
            else
            {
                MessageBox.Show("failed");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customers emp = new Customers();
            emp.Id = int.Parse(textBox5.Text);
            CustomersBll empbll = new CustomersBll();
            bool c = empbll.DeleteCustomersBll(emp);
            if (c == true)
            {
                MessageBox.Show("Deleted");
                Display();
            }
            else
            {
                MessageBox.Show("failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers emp = new Customers();
            emp.Id = int.Parse(textBox5.Text);
            CustomersBll empbll = new CustomersBll();
            DataTable dt = new DataTable();
            dt = empbll.SearchByIdCustomersBll(emp);
            if (dt.Rows.Count > 1)
            {
                dataGridView1.DataSource = dt;
            }
            else if (dt.Rows.Count > 0 && dt.Rows.Count < 2)
            {
                textBox1.Text = dt.Rows[0][1].ToString();
                textBox2.Text = dt.Rows[0][2].ToString();
                textBox3.Text = dt.Rows[0][3].ToString();
                textBox5.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Close();
        }
    }
}
