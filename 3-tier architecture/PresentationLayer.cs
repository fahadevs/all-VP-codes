using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            }
            else
            {
                MessageBox.Show("failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Id=int.Parse(textBox4.Text);
            EmployeBll empbll = new EmployeBll();
            DataTable dt = new DataTable();
            dt = empbll.SearchByIdEmployeeBll(emp);
            if (dt.Rows.Count>1)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                textBox1.Text = dt.Rows[0]["empname"].ToString();
                textBox2.Text = dt.Rows[0][2].ToString();
                textBox3.Text = dt.Rows[0][3].ToString();
            }
        }
    }
}
