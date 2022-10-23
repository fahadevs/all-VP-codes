using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SuppliersDal
    {
        public bool AddSuppliersDal(Suppliers e)
        {
            return new Dbcon().UDI(
                "Insert into Suppliers (SupplierName,SupplierCell,SupplierAddress) values('" + e.Suppliersname + "','" + e.Supplierscell + "','" + e.Suppliersaddress + "')");
        }
        public bool UpdateSuppliersDal(Suppliers e)
        {
            return new Dbcon().UDI(
                "Update Suppliers set SupplierName='" + e.Suppliersname + "',SupplierCell='" + e.Supplierscell + "',SupplierAddress='" + e.Suppliersaddress + "' where Id='" + e.Id + "'");
        }
        public bool DeleteSuppliersDal(Suppliers e)
        {
            return new Dbcon().UDI(
                "Delete from Suppliers where Id='" + e.Id + "'");
        }
        public DataTable SearchbyidSuppliersDal(Suppliers e)
        {
            return new Dbcon().Search(
                "Select * from Suppliers where Id='" + e.Id + "'");
        }
        public DataTable SearchSuppliersDal()
        {
            return new Dbcon().Search("Select * from Suppliers");
        }
    }
}
