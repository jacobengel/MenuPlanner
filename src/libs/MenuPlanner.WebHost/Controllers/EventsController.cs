namespace MenuPlanner.WebHost.Controllers
{
    using System;
    using System.Collections.Generic;
    
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using API.Models.Events;

    [Route("events")]
    public class EventsController : Controller
    {
        [HttpGet("{id}")]
        public HttpResponse GetEvent(string id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public HttpResponse GetEvents()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public HttpResponse CreateEvent(Event event)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public HttpResponse UpdateEvent([FromUri]string id, Event event)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public HttpResponse DeleteEvent([FromUri]string id)
        {
            throw new NotImplementedException();
        }        
    }
}