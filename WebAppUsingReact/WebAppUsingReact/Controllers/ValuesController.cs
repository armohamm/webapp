using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppUsingReact.Models;

namespace WebAppUsingReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ICollection<Test> values = new List<Test> {
            new Test{Id=1, Value= "value1" },
            new Test{Id=2, Value= "value2" },
            new Test{Id=3, Value= "value3" },
            new Test{Id=4, Value= "value4" },
        };
        // GET: api/Values
        [HttpGet]
        public IEnumerable<Test> Get()
        {
            return values;
        }

        // GET: api/Values/5
        [HttpGet("{id}", Name = "Get")]
        public Test Get(int id)
        {
            return values
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        // POST: api/Values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            values.Add(new Test { Id=10, Value=value});
        }

        // PUT: api/Values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
