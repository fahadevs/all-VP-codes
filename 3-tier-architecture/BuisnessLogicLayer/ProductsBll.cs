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
    public class ProductsBll
    {
        ProductsDal prodal = new ProductsDal();
        public bool AddProductsBll(Product e)
        {
            return prodal.AddProductsDal(e);
        }
        public bool UpdateProductsBll(Product e)
        {
            return prodal.UpdateProductsDal(e);
        }
        public bool DeleteProductsBll(Product e)
        {
            return prodal.DeleteProductsDal(e);
        }

        public DataTable SearchByIdProductsBll(Product e)
        {

            return prodal.SearchbyidProductsDal(e);
        }
        public DataTable SearchProductsBll()
        {

            return prodal.SearchProductsDal();
        }
    }
}
