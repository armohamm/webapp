using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppUsingReact.Models;
using WebAppUsingReact.Services;

namespace WebAppUsingReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public TestRepository Repository { get; }

        public ValuesController(TestRepository repository)
        {
            Repository = repository;
        }
        // GET: api/Values
        [HttpGet]
        public IEnumerable<Test> Get()
        {
            return Repository.GetAll();
        }

        // GET: api/Values/5
        [HttpGet("{id}", Name = "Get")]
        public Test Get(int id)
        {
            return Repository.GetSingle(x => x.Id == id);
        }

        // POST: api/Values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            Repository.Add(new Test { Value = value });
            Repository.Commit();
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
