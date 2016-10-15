using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pago.Web.Models;

namespace Pago.Web.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            return new Hero[] 
            { 
                new Hero { id = 0, name = "zero"},
                new Hero { id = 1, name = "uno"},
                new Hero { id = 2, name = "dos"},
                new Hero { id = 3, name = "tres"},
                new Hero { id = 4, name = "cuatro"},
                new Hero { id = 5, name = "cinco"} 
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
