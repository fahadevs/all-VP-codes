using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppProps;
using BuisnessLogicLayer;
namespace _3_tier_architecture
{
    public partial class PresentationLayer : Form
    {
        public PresentationLayer()
        {
            InitializeComponent();
            Display();
        }
        public void Display()
        {
            DataTable dt = new DataTable();
            dt = new EmployeBll().SearchEmployeeBll();
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Empname= textBox1.Text;
            emp.Empcell = textBox2.Text;
            emp.Empaddress = textBox3.Text;
            EmployeBll empbll = new EmployeBll();
            bool c=empbll.AddEmployeeBll(emp);
            if(c==true)
            {
                MessageBox.Show("success");
                Display();
            }
            else
            {
                MessageBox.Show("failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Id=int.Parse(textBox5.Text);
            EmployeBll empbll = new EmployeBll();
            DataTable dt = new DataTable();
            dt = empbll.SearchByIdEmployeeBll(emp);
            if (dt.Rows.Count>1)
            {
                dataGridView1.DataSource = dt;
            }
            else if(dt.Rows.Count > 0 && dt.Rows.Count < 2 )
            {
                textBox1.Text = dt.Rows[0]["EmpName"].ToString();
                textBox2.Text = dt.Rows[0][2].ToString();
                textBox3.Text = dt.Rows[0][3].ToString();
                textBox5.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Empname = textBox1.Text;
            emp.Empcell = textBox2.Text;
            emp.Empaddress = textBox3.Text;
            emp.Id = int.Parse(textBox5.Text);
            EmployeBll empbll = new EmployeBll();
            bool c = empbll.UpdateEmployeeBll(emp);
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
            Employee emp = new Employee();
            emp.Id = int.Parse(textBox5.Text);
            EmployeBll empbll = new EmployeBll();
            bool c = empbll.DeleteEmployeeBll(emp);
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

        private void button5_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Close();
        }
    }
}
