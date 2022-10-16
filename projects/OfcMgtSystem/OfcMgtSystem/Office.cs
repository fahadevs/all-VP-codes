using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfcMgtSystem
{
    public class Office
    {
        public int id;
        public String empname;
        public String empcellnum;
        public String empaddress;
        public Office(String name,String cell,String address)
        {
            empname = name;
            empcellnum = cell;
            empaddress = address;
        }
    }
}
