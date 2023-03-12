namespace MenuPlanner.WebHost.Controllers
{
    using System;
    using System.Collections.Generic;
    
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using API.Models.People;

    [Route("contacts")]
    public class ContactsController : Controller
    {
        [HttpGet("{id}")]
        public HttpResponse GetContact(string id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public HttpResponse GetContacts()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public HttpResponse CreateContact([FromBody]Person contact)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public HttpResponse UpdateContact(string id, [FromBody]Person contact)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public HttpResponse DeleteContact(string id)
        {
            throw new NotImplementedException();
        }        
    }
}