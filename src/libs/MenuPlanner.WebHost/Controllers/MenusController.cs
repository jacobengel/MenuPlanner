namespace MenuPlanner.WebHost.Controllers
{
    using System;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using Domain;

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
        public HttpResponse CreateMenu(Menu menu)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public HttpResponse UpdateMenu(Menu menu)
        {
            throw new NotImplementedException();
        }
    }
}
