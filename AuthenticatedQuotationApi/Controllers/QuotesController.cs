using AuthenticatedQuotationApi.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AuthenticatedQuotationApi.Controllers
{
    public class QuotesController : ApiController
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        //static seed Data
        static List<Quote> _quotes = new List<Quote>()
        {
             new Quote() {Id=0, Author="Spiderman", Description = "With great power comes great responsibility", Title = "Power" }

        };

        // GET: api/Quotes
        //public IEnIumerable<Quote> Get()
        [HttpGet]
       
        public IHttpActionResult LoadQuotes(string sort)
        {
            //var quotes = _dbContext.Quotes;
            //return Ok(quotes);
            IQueryable<Quote> quotes;

            switch (sort)
            {
                case "desc":
                    quotes = _dbContext.Quotes.OrderByDescending(q => q.CreatedAt);
                    break;
                case "asc":
                    quotes = _dbContext.Quotes.OrderBy(q => q.CreatedAt);
                    break;
                default:
                    quotes = _dbContext.Quotes;
                    break;

            }
            //return _quotes;
            return Ok(quotes);


        }

        // GET: api/Quotes/5
        //public Quote Get(int id)
        [HttpGet]
    
        public IHttpActionResult LoadQuote(int id)
        {
            //return _quotes[id] = quote;
            var quote =_dbContext.Quotes.Find(id);
            if(quote == null)
            {
                return NotFound();
            }
            return Ok(quote);
        }


        [HttpGet]
        [Route("api/Quotes/Test/{id}")]
        public int Test(int id)
        {
            return id;
        }
        // POST: api/Quotes
        //public void Post([FromBody] Quote quote)
        [HttpPost]
        public IHttpActionResult PostQuotes([FromBody] Quote quote)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //_quotes.Add(quote);
            _dbContext.Quotes.Add(quote);
            _dbContext.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }

        // PUT: api/Quotes/5
        //public void Put(int id, [FromBody] Quote quote)
        [HttpPut]
        public IHttpActionResult PutQuotes(int id, [FromBody] Quote quote)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            else
            {
                var item = _dbContext.Quotes.FirstOrDefault(q => q.Id == id);
                if (item == null)
                {
                    return BadRequest("Record not found");
                }
                item.Author = quote.Author;
                item.Title = quote.Title;
                item.Description = quote.Description;
                item.Type = quote.Type;
                _dbContext.SaveChanges();
                return Ok("Record updated succesffully");
            }
            
        }

        // DELETE: api/Quotes/5
        //public void Delete(int id)
        [HttpDelete]
        public IHttpActionResult DeleteQuotes(int id)
        {
            var item = _dbContext.Quotes.Find(id);
            if(item == null)
            {
                return BadRequest("Record not found");
            }
            _dbContext.Quotes.Remove(item);
            _dbContext.SaveChanges();
            return Ok("Record deleted successfully");
        }

        [HttpGet]
        [Route("api/Quotes/PagingQuote/{pageNumber=1}/{pageSize=1}")]
        public IHttpActionResult PagingQuote(int pageNumber, int pageSize)
        {
            var quotes = _dbContext.Quotes.OrderBy(q => q.Id);
            return Ok(quotes.Skip((pageNumber-1) * pageSize).Take(pageSize));

        }

        [HttpGet]
        [Route("api/Quotes/SearchQuote/{type=}")]
        public IHttpActionResult SearchQuote(string type)
        {
            var quotes = _dbContext.Quotes.Where(q => q.Type.StartsWith(type));
            return Ok(quotes);
        }
    }
}
