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
        public ActionResult<Event> GetEvent([FromRoute]string id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Event>> GetEvents()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult CreateEvent([FromBody]Event evnt)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public ActionResult UpdateEvent([FromRoute]string id, [FromBody]Event evnt)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult DeleteEvent([FromRoute]string id)
        {
            throw new NotImplementedException();
        }        
    }
}