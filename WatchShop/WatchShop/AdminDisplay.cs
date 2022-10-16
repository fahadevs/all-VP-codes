using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;

namespace WatchShop
{
    public partial class AdminDisplay : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lovel\OneDrive\Documents\WatchShop.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int Id = 0;
        public AdminDisplay()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from watches", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            Id = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update watches set brand=@brand,price=@price,gender=@gender  where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@brand", textBox1.Text);
            cmd.Parameters.AddWithValue("@price", textBox2.Text);
            cmd.Parameters.AddWithValue("@gender", textBox3.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Inserted Succesfully");
            con.Close();
            DisplayData();
            ClearData();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                cmd = new SqlCommand("insert into watches(brand,price,gender) values(@brand,@price,@gender)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@brand", textBox1.Text);
                cmd.Parameters.AddWithValue("@price", textBox2.Text);
                cmd.Parameters.AddWithValue("@gender", textBox3.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Succesfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Insert Valid Data");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Id!=0)
            {
                cmd = new SqlCommand("delete from watches where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id",Id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Succesfully");
                DisplayData();
                ClearData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
