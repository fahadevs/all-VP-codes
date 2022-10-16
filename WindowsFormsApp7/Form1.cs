using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ConfigurationManager.AppSettings["k1"]);
            MessageBox.Show(ConfigurationManager.AppSettings["k2"]);
            MessageBox.Show(ConfigurationManager.AppSettings["k3"]);
        }

        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(652, 405);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(ConfigurationManager.AppSettings["k1"]);
            int d=Convert.ToInt32(ConfigurationManager.AppSettings["k2"]);
            int c = a + d;
            MessageBox.Show(ConfigurationManager.AppSettings["k1"]);
            MessageBox.Show(ConfigurationManager.AppSettings["k2"]);
            MessageBox.Show(c.ToString());
        }
    }
}
