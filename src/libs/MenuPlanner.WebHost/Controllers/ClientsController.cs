namespace MenuPlanner.WebHost.Controllers
{
    using System;
    using System.Collections.Generic;
    
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using API.Models.People;

    [ApiController]
    [Route("clients")]
    public class ClientsController : ControllerBase
    {
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Client> GetClient([FromRoute]string id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Client>> GetClients()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult CreateClient([FromBody]Client client)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public ActionResult UpdateClient([FromRoute]string id, [FromBody]Client client)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public ActionResult DeleteClient([FromRoute]string id)
        {
            throw new NotImplementedException();
        }        
    }
}
