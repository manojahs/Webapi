using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapi.Model
{
    [ModelBinder(typeof(CustomCountryDetils))]
    public class County
    {
        public string action { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
