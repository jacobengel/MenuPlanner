namespace MenuPlanner.WebHost.Controllers
{
    using System;
    using System.Collections.Generic;
    
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using API.Models.Events;

    [ApiController]
    [Route("events")]
    public class EventsController : ControllerBase
    {
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Event> GetEvent(string id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult<List<Event>> GetEvents()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult CreateEvent(Event evnt)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateEvent([FromUri]string id, Event evnt)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEvent([FromUri]string id)
        {
            throw new NotImplementedException();
        }        
    }
}