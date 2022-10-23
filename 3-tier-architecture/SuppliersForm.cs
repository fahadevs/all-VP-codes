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
    public partial class SuppliersForm : Form
    {
        public SuppliersForm()
        {
            InitializeComponent();
            Display();
        }
        public void Display()
        {
            DataTable dt = new DataTable();
            dt = new SuppliersBll().SearchSuppliersBll();
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Suppliers emp = new Suppliers();
            emp.Suppliersname = textBox1.Text;
            emp.Supplierscell = textBox2.Text;
            emp.Suppliersaddress = textBox3.Text;
            SuppliersBll empbll = new SuppliersBll();
            bool c = empbll.AddSuppliersBll(emp);
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


        private void button5_Click_1(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Suppliers emp = new Suppliers();
            emp.Suppliersname = textBox1.Text;
            emp.Supplierscell = textBox2.Text;
            emp.Suppliersaddress = textBox3.Text;
            emp.Id = int.Parse(textBox5.Text);
            SuppliersBll empbll = new SuppliersBll();
            bool c = empbll.UpdateSuppliersBll(emp);
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            Suppliers emp = new Suppliers();
            emp.Id = int.Parse(textBox5.Text);
            SuppliersBll empbll = new SuppliersBll();
            bool c = empbll.DeleteSuppliersBll(emp);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Suppliers emp = new Suppliers();
            emp.Id = int.Parse(textBox5.Text);
            SuppliersBll empbll = new SuppliersBll();
            DataTable dt = new DataTable();
            dt = empbll.SearchByIdSuppliersBll(emp);
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
    }
}
