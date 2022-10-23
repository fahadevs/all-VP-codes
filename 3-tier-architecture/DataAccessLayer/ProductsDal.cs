using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;
namespace DataAccessLayer
{
    public class ProductsDal
    {
        public bool AddProductsDal(Product e)
        {
            return new Dbcon().UDI(
                "Insert into Products (ProductName,ProductQuantity,ProductPrice) values('" + e.Productsname + "','" + e.Productsquantity+ "','" + e.Productsprice+ "')");
        }
        public bool UpdateProductsDal(Product e)
        {
            return new Dbcon().UDI(
                "Update Products set ProductName='" + e.Productsname + "',ProductQuantity='" + e.Productsquantity+ "',ProductPrice='" + e.Productsprice+ "' where Id='" + e.Id+ "'");
        }
        public bool DeleteProductsDal(Product e)
        {
            return new Dbcon().UDI(
                "Delete from Products where Id='" + e.Id + "'");
        }
        public DataTable SearchbyidProductsDal(Product e)
        {
            return new Dbcon().Search(
                "Select * from Products where Id='" + e.Id + "'");
        }
        public DataTable SearchProductsDal()
        {
            
                return new Dbcon().Search("Select * from Products");
            
        }
    }
}
