using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapi.Model;
using Webapi.Repository;

namespace Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductRepository _productRepository1;

        public ProductController(IProductRepository productRepository,IProductRepository productRepository1)
        {
            _productRepository = productRepository;
            _productRepository1 = productRepository;

        }

        [HttpPost("")]
        public IActionResult AddProduct(ProductModel product)
        {
            _productRepository.getData(product);
            var products = _productRepository1.GetAll();

            return Ok(products);
        }
        
        [HttpGet("")]
        public IActionResult GetProduct()
        {
            var products = _productRepository.getName();
            var test = _productRepository1.getName();

            return Ok(test);
        }

    }
}
