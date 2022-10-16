using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculation;

namespace CalculaterAssemblies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        calculate c = new calculate();
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            textBox3.Text = c.add(a, b).ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(" " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                textBox3.Text = c.sub(a, b).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(" " + ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                textBox3.Text = c.mul(a, b).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(" " + ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                textBox3.Text = c.div(a, b).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(" " + ex.ToString());
            }
        }
    }
}
