using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapi.Model;

namespace Webapi.Repository
{
    public class TestRepositorycs : IProductRepository
    {
        public List<ProductModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public int getData(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public string getName()
        {
            return "Test";
        }
    }
}
