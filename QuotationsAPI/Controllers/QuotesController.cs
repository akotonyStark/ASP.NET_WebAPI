using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuotationsAPI.Controllers
{
    public class QuotesController : ApiController
    {
        // GET: api/Quotes
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Quotes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Quotes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Quotes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Quotes/5
        public void Delete(int id)
        {
        }
    }
}
