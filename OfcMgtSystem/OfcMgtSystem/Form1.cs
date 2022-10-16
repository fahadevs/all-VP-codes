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

namespace OfcMgtSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ID = txtid.Text;
            string Name = txtName.Text;
            string CellNum = txtCell.Text;
            string Address = txtAddress.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

            string query = "INSERT INTO Employeetbl VALUES('" + ID + "','" + Name + "','" + CellNum + "','" + Address + "')";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int c = cmd.ExecuteNonQuery();
                if (c > 0)
                {
                    MessageBox.Show("Record Inserted Successfully");
                }
                else
                {
                    MessageBox.Show("Record NOT Inserted ");
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

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = txtid.Text;
            string Name = txtName.Text;
            string CellNum = txtCell.Text;
            string Address = txtAddress.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=CS-LAB1-009\NUMLCS;Initial Catalog=test;Integrated Security=True");

            string query = "Update Employeetbl set EmpName='"+Name+"',EmpCell='"+CellNum+"',EmpAddress='"+Address+"' where Id='"+ID+"'";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int c = cmd.ExecuteNonQuery();
                if (c > 0)
                {
                    MessageBox.Show("Record Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Record NOT Inserted ");
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
