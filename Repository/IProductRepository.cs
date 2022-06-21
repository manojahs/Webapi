using System.Collections.Generic;
using Webapi.Model;

namespace Webapi.Repository
{
    public interface IProductRepository
    {
        List<ProductModel> GetAll();
        int getData(ProductModel productModel);

        string getName();
    }
}