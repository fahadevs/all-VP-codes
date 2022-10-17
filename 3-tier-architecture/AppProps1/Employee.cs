using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class Employee
    {
        private int id;
        private String empname, empcell, empaddress;

        public string Empname { get => empname; set => empname = value; }
        public string Empcell { get => empcell; set => empcell = value; }
        public string Empaddress { get => empaddress; set => empaddress = value; }
        public int Id { get => id; set => id = value; }
    }
}
