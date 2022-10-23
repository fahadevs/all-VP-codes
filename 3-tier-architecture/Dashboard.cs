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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SuppliersForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ProductsForm().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new CustomersForm().Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PresentationLayer().Show();
        }
    }
}
