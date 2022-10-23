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
    public class CustomersBll
    {
        CustomersDal empdal = new CustomersDal();
        public bool AddCustomersBll(Customers e)
        {
            return empdal.AddCustomersDal(e);
        }
        public bool UpdateCustomersBll(Customers e)
        {
            return empdal.UpdateCustomersDal(e);
        }
        public bool DeleteCustomersBll(Customers e)
        {
            return empdal.DeleteCustomersDal(e);
        }

        public DataTable SearchByIdCustomersBll(Customers e)
        {

            return empdal.SearchbyidCustomersDal(e);
        }
        public DataTable SearchCustomersBll()
        {

            return empdal.SearchCustomersDal();
        }
    }
}
