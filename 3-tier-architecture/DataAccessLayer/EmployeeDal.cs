using AppProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DataAccessLayer
{
    public class EmployeeDal
    {
        public bool AddEmployeeDal(Employee e)
        {
            return new Dbcon().UDI(
                "Insert into Employees (empname,empcell,empaddress) values('" + e.Empname + "','" + e.Empcell + "','" + e.Empaddress + "')");
        }
        public bool UpdateEmployeeDal(Employee e)
        {
            return new Dbcon().UDI(
                "Update Employees set empname='" + e.Empname + "',empcell='" + e.Empcell + "',empaddress='" + e.Empaddress + "'");
        }
        public bool DeleteEmployeeDal(Employee e)
        {
            return new Dbcon().UDI(
                "Delete from Employees Id='" + e.Id + "'");
        }
        public DataTable SearchbyidEmployeeDal(Employee e)
        {
            return new Dbcon().SearchById(
                "Select * from Employees where Id='" + e.Id + "'");
        }
        public bool SearchEmployeeDal()
        {
            return new Dbcon().UDI("Select * from Employees");
        }
    }
}
