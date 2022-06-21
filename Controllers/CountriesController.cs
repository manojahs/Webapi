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
    public class CountriesController : ControllerBase
    {
        [BindProperty(SupportsGet=true)]
        public County CountryModel { get; set; }

        [HttpGet("")]
        public IActionResult GetData()
        {
            return Ok($"Name is {this.CountryModel.Name}," + $"\nId is {this.CountryModel.Id}");
        }

        [HttpGet("search")]
        public IActionResult SearchCountries([ModelBinder(typeof(CustomModelBinder))]string[] countries)
        {
            return Ok(countries);

        }

        [HttpGet("{id}")]
        public IActionResult CountryDetails([ModelBinder(Name ="Name")]County country)
        {
            return Ok(country);
        }

    }
}
