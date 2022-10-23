using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbcon
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new CustomersForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            new ProductsForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SuppliersForm().Show();
        }
    }
}
