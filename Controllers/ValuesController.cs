using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Webapi.Model;

namespace Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [Route("{id}/basic")]
        public IActionResult getMethod(int id)
        {
            if(id==0)
            {
                return NotFound();
            }
            var animal = new List<Manoj>()
            { 
              new Manoj() {Id=1,Name="Manoj" },
              new Manoj() { Id=2,Name="Manali" }};
            return Ok(animal);
        }
    }
}
