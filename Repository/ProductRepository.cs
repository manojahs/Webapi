using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapi.Model;

namespace Webapi.Repository
{
    public class ProductRepository : IProductRepository
    {

        private List<ProductModel> prod = new List<ProductModel>();
        public int getData(ProductModel productModel)
        {

            productModel.Id = prod.Count + 1; 

           prod.Add(productModel);

            return productModel.Id;
        }

        public List<ProductModel> GetAll()
        {
            return prod;
        }

        public string getName()
        {
            return "Product";
        }
    }
}
