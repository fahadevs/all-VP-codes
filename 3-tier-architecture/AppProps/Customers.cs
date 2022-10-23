using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class Customers
    {
        private int id;
        private String customersname, customerscell, customersaddress;

        public int Id { get => id; set => id = value; }
        public string Customersname { get => customersname; set => customersname = value; }
        public string Customerscell { get => customerscell; set => customerscell = value; }
        public string Customersaddress { get => customersaddress; set => customersaddress = value; }
    }
}
