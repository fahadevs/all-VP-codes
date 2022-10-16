using System.Data.SqlClient;
using System.Drawing;

namespace WatchShop
{

    
    public partial class User : Form
    {


        public static string name = "";
        public User()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lovel\OneDrive\Documents\WatchShop.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd;
            /*cmd = new SqlCommand("SELECT * FROM users WHERE username='" + textBox1.Text + "' AND password='" + textBox2.Text + "'", con);
            con.Open();
            int c=cmd.ExecuteNonQuery();
            con.Close();*/
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM users WHERE username='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader(); dr.Read();
            
            if (dr.HasRows)
            {
                name = textBox1.Text;
                MessageBox.Show("Welcome");
                Display d = new Display();
                d.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username or Password");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.ShowDialog();
        }
    }
}