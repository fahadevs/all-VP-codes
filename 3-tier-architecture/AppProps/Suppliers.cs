using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class Suppliers
    {
        private int id;
        private String suppliersname, supplierscell, suppliersaddress;

        public int Id { get => id; set => id = value; }
        public string Suppliersname { get => suppliersname; set => suppliersname = value; }
        public string Supplierscell { get => supplierscell; set => supplierscell = value; }
        public string Suppliersaddress { get => suppliersaddress; set => suppliersaddress = value; }
    }
}
