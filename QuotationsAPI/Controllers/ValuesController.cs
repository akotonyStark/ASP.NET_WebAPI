using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuotationsAPI.Controllers
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
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}


//using QuotationsAPI.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Http;

//namespace QuotationsAPI.Controllers
//{
//    public class QuotesController : ApiController
//    {
//        static List<Quote> _quotes = new List<Quote>()
//        {
//             new Quote() {Id=0, Author="Spiderman", Description = "With great power comes great responsibility", Title = "Power" }

//        };


//        public IEnumerable<Quote> Get()
//        {
//            return _quotes;
//        }

//        public void PostQuote([FromBody] Quote quote)
//        {
//            _quotes.Add(quote);
//        }

//        public void PutQuote(int Id, [FromBody] Quote quote)
//        {
//            _quotes[Id] = quote;
//        }

//        public void DeletePost(int Id)
//        {
//            _quotes.RemoveAt(Id);
//        }


//    }
//}