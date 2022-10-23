using AppProps;
using BuisnessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_tier_web
{
    public partial class ProductsWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Product emp = new Product();
            emp.Productsname = TextBox2.Text;
            emp.Productsquantity = TextBox3.Text;
            emp.Productsprice = TextBox4.Text;
            ProductsBll empbll = new ProductsBll();
            bool c = empbll.AddProductsBll(emp);
            if (c == true)
            {

                Label1.Visible = true;
                Label1.Text = "Insertion Succesfull";
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Insertion failed";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Product emp = new Product();
            emp.Productsname = TextBox2.Text;
            emp.Productsquantity = TextBox3.Text;
            emp.Productsprice = TextBox4.Text;
            ProductsBll empbll = new ProductsBll();
            bool c = empbll.UpdateProductsBll(emp);
            if (c == true)
            {
                Label1.Visible = true;
                Label1.Text = "Update Succesfull";
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Update failed";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Product emp = new Product();
            emp.Id = int.Parse(TextBox1.Text);
            ProductsBll empbll = new ProductsBll();
            bool c = empbll.DeleteProductsBll(emp);
            if (c == true)
            {
                Label1.Visible = true;
                Label1.Text = "Deleted";
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Delete failed";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Product emp = new Product();
            emp.Id = int.Parse(TextBox1.Text);
            ProductsBll empbll = new ProductsBll();
            DataTable dt = new DataTable();
            dt = empbll.SearchByIdProductsBll(emp);
            if (dt.Rows.Count > 1)
            {
                GridView1.DataSource = dt;
            }
            else if (dt.Rows.Count > 0 && dt.Rows.Count < 2)
            {
                TextBox2.Text = dt.Rows[0]["EmpName"].ToString();
                TextBox3.Text = dt.Rows[0][2].ToString();
                TextBox4.Text = dt.Rows[0][3].ToString();
                TextBox1.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "No Data Found";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }
}