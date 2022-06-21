using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapi.Model;

namespace Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitController : ControllerBase 
    {
        //[Route("{Name}/{Id}")]

        [HttpPost("{id}")]
        public IActionResult Geet([FromRoute]int id, [FromHeader]string developer)
        {
            return Ok($"Name is: {developer}");
        }
    }
}
