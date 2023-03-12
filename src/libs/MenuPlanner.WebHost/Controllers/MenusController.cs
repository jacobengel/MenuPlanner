namespace MenuPlanner.WebHost.Controllers
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using API.Models.Events;

    [ApiController]
    [Route("menus")]
    public class MenusController : ControllerBase
    {
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Menu> GetMenu([FromRoute]string id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Menu>> GetMenus()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult CreateMenu([FromBody]Menu menu)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public ActionResult UpdateMenu([FromRoute]string id, [FromBody]Menu menu)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public ActionResult DeleteMenu([FromRoute]string id)
        {
            throw new NotImplementedException();
        }
    }
}
