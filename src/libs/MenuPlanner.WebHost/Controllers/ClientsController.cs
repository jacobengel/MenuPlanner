namespace MenuPlanner.WebHost.Controllers
{
    using System;
    using System.Collections.Generic;
    
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using API.Models.People;

    [Route("clients")]
    public class ClientsController : Controller
    {
        [HttpGet("{id}")]
        public HttpResponse GetClient(string id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public HttpResponse GetClients()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public HttpResponse CreateClient([FromBody]Client client)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public HttpResponse UpdateClient(string id, [FromBody]Client client)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public HttpResponse DeleteClient(string id)
        {
            throw new NotImplementedException();
        }        
    }
}
