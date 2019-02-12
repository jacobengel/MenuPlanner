namespace MenuPlanner.WebHost.Controllers
{
    using System;
    using System.Collections.Generic;
    
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using Domain.People;

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
        public HttpResponse CreateClient(Client client)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public HttpResponse UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
