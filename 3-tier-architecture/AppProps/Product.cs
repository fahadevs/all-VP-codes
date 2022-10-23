using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{

    public class Product
    {
        private int id;
        private String productsname, productsquantity, productsprice;


        public int Id { get => id; set => id = value; }
        public string Productsname { get => productsname; set => productsname = value; }
        public string Productsquantity { get => productsquantity; set => productsquantity = value; }
        public string Productsprice { get => productsprice; set => productsprice = value; }
    }
}
