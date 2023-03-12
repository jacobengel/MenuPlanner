namespace MenuPlanner.WebHost.Controllers
{
    using System;
    using System.Collections.Generic;
    
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using API.Models.Locations;

    [Route("locations")]
    public class LocationsController : Controller
    {
        [HttpGet("{id}")]
        public HttpResponse GetLocation(string id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public HttpResponse GetLocations()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public HttpResponse CreateLocation([FromBody]Location location)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public HttpResponse UpdateLocation(string id, [FromBody]Location location)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public HttpResponse DeleteLocation(string id)
        {
            throw new NotImplementedException();
        }        
    }
}