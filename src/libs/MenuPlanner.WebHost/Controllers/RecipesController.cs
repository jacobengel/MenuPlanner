namespace MenuPlanner.WebHost.Controllers
{
    using System;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using Domain;

    [Route("recipes")]
    public class RecipesController : Controller
    {
        [HttpGet("{id}")]
        public HttpResponse GetRecipe(string id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public HttpResponse GetRecipes()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public HttpResponse CreateRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public HttpResponse UpdateRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
