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

namespace OfcMgtSys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Code = txtid.Text;
            string Name = txtName.Text;
            string CellNum = txtCell.Text;
            string Address = txtAddress.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=CS-LAB1-012\NUMLCS;Initial Catalog=OfcDB;Integrated Security=True");

            string query = "INSERT INTO Employee VALUES('" + Code + "','" + Name + "','" + CellNum + "','" + Address + "')";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int c=cmd.ExecuteNonQuery();
                if(c>0)
                { 
                MessageBox.Show("Record Inserted Successfully");
                }
                else 
                {
                    MessageBox.Show("Not Successful");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
