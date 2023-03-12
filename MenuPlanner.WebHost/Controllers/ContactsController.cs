namespace MenuPlanner.WebHost.Controllers
{
    using System;
    using System.Collections.Generic;
    
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using API.Models.People;

    [ApiController]
    [Route("contacts")]
    public class ContactsController : ControllerBase
    {
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Person> GetContact([FromRoute]string id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Person>> GetContacts()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult CreateContact([FromBody]Person contact)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public ActionResult UpdateContact([FromRoute]string id, [FromBody]Person contact)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public ActionResult DeleteContact([FromRoute]string id)
        {
            throw new NotImplementedException();
        }        
    }
}