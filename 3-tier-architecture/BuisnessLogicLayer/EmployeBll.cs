using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;
using DataAccessLayer;
using System.Data;
namespace BuisnessLogicLayer
{
    public class EmployeBll
    {
        EmployeeDal empdal = new EmployeeDal();
        public bool AddEmployeeBll(Employee e)
        {
            return empdal.AddEmployeeDal(e);
        }
        public bool UpdateEmployeeBll(Employee e)
        {
            return empdal.UpdateEmployeeDal(e);
        }
        public bool DeleteEmployeeBll(Employee e)
        {
            return empdal.DeleteEmployeeDal(e);
        }

        public DataTable SearchByIdEmployeeBll(Employee e)
        {
            
            return empdal.SearchbyidEmployeeDal(e);
        }
        public DataTable SearchEmployeeBll()
        {

            return empdal.SearchEmployeeDal();
        }
    }
}
