using QuotationsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace QuotationsAPI.Controllers
{
    public class QuotesController: ApiController
    {
        List<Quote> _quotes = new List<Quote>()
        {
             new Quote() {Id=0, Author="Spiderman", Description = "With great power comes great responsibility", Title = "Power" }

        };


        public IEnumerable<Quote> Get()
        {
            return _quotes;
        }

       
    }
}