using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyAPI.Models;
using Newtonsoft.Json.Linq;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        [HttpGet("GetResponse")]
        public string GetResponse(string input)
        {

            if (input == "hai")
                return "hello";
            else if (input=="hello")
            {
                return "hai";
            }
            return "I don't know what you are saying..........";
        }
        [HttpPost("GetResponse")]
        public string GetResponse1(Response response)
        {
            if (response.input == "hai")
                return "hello";
            else if (response.input == "hello")
            {
                return "hai";
            }
            return "I don't know what you are saying..........";
        }
    }
}
