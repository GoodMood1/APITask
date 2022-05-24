using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogsAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return $"Value id: {id}";
        }

        // POST api/values
        public string Post([FromBody] string value)
        {
            return $"Value [{value}] was created";
        }

        // PUT api/values/5
        public bool Put(int id, [FromBody] string value)
        {
            return true;
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            return $"Object #{id} was deleted";
        }
    }
}
