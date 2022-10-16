using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linktosql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               /*for getting all values from db*/
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from u in dc.watches
                          /*this is select *
                          select u;
                          */
                          /*selecting specific columns*/
                      select new
                      {
                          Brand = u.brand,
                          Price = u.price,
                          gender = u.gender
                      }
                      dataGridView1.DataSource = res.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*taking input*/
            DataClasses1DataContext dc = new DataClasses1DataContext();
            watch u = new watch();
            /*u.brand = textbox1.Text;*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*searching*/

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*ordering data in descending order*/

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*update*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*delete*/
        }
    }
}
