namespace MenuPlanner.WebHost.Controllers
{
    using System;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using API.Models.Events;

    public class MenusController : Controller
    {
        [HttpGet("{id}")]
        public HttpResponse GetMenu(string id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public HttpResponse GetMenus()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public HttpResponse CreateMenu([FromBody]Menu menu)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public HttpResponse UpdateMenu(string id, [FromBody]Menu menu)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public HttpResponse DeleteMenu(string id)
        {
            throw new NotImplementedException();
        }
    }
}
