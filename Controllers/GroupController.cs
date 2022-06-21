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
    //[BindProperties(SupportsGet =true)]
    public class GroupController : ControllerBase
    {
        //public string Name { get; set; }
        //public int Id { get; set; }
        [BindProperty]

        public Manoj manojsdata { get; set; }

        [HttpPost("")]
        public IActionResult GetData()
        {
            return Ok($"Name is {this.manojsdata.Name}," + $"\nId is {this.manojsdata.Id}");
        }

        [HttpGet("name")]
        public IActionResult GetProduct([FromServices] IProductRepository _productRepository1)
        {
            var test = _productRepository1.getName();

            return Ok(test);
        }

    }

}
