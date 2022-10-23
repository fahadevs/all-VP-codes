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
                "Insert into Employees (EmpName,EmpCell,EmpAddress) values('" + e.Empname + "','" + e.Empcell + "','" + e.Empaddress + "')");
        }
        public bool UpdateEmployeeDal(Employee e)
        {
            return new Dbcon().UDI(
                "Update Employees set EmpName='" + e.Empname + "',EmpCell='" + e.Empcell + "',EmpAddress='" + e.Empaddress + "' where EmpId='" + e.Id + "'");
        }
        public bool DeleteEmployeeDal(Employee e)
        {
            return new Dbcon().UDI(
                "Delete from Employees where EmpId='" + e.Id + "'");
        }
        public DataTable SearchbyidEmployeeDal(Employee e)
        {
            return new Dbcon().Search(
                "Select * from Employees where EmpId='" + e.Id + "'");
        }
        public DataTable SearchEmployeeDal()
        {
            return new Dbcon().Search("Select * from Employees");
        }
    }
}
