using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomersDal
    {
        public bool AddCustomersDal(Customers e)
        {
            return new Dbcon().UDI(
                "Insert into Customers (CustomerName,CustomerCell,CustomerAddress) values('" + e.Customersname + "','" + e.Customerscell + "','" + e.Customersaddress + "')");
        }
        public bool UpdateCustomersDal(Customers e)
        {
            return new Dbcon().UDI(
                "Update Customers set CustomerName='" + e.Customersname + "',CustomerCell='" + e.Customerscell + "',CustomerAddress='" + e.Customersaddress + "' where Id='" + e.Id + "'");
        }
        public bool DeleteCustomersDal(Customers e)
        {
            return new Dbcon().UDI(
                "Delete from Customers where Id='" + e.Id + "'");
        }
        public DataTable SearchbyidCustomersDal(Customers e)
        {
            return new Dbcon().Search(
                "Select * from Customers where Id='" + e.Id + "'");
        }
        public DataTable SearchCustomersDal()
        {
            return new Dbcon().Search("Select * from Customers");
        }
    }
}
