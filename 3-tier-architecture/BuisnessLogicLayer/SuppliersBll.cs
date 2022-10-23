using AppProps;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer
{
    public class SuppliersBll
    {
        SuppliersDal empdal = new SuppliersDal();
        public bool AddSuppliersBll(Suppliers e)
        {
            return empdal.AddSuppliersDal(e);
        }
        public bool UpdateSuppliersBll(Suppliers e)
        {
            return empdal.UpdateSuppliersDal(e);
        }
        public bool DeleteSuppliersBll(Suppliers e)
        {
            return empdal.DeleteSuppliersDal(e);
        }

        public DataTable SearchByIdSuppliersBll(Suppliers e)
        {

            return empdal.SearchbyidSuppliersDal(e);
        }
        public DataTable SearchSuppliersBll()
        {

            return empdal.SearchSuppliersDal();
        }
    }
}
