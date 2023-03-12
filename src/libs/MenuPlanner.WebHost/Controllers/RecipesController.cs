namespace MenuPlanner.WebHost.Controllers
{
    using System;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using API.Models.Recipes;

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
        public HttpResponse CreateRecipe([FromBody]Recipe recipe)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public HttpResponse UpdateRecipe(string id, [FromBody]Recipe recipe)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public HttpResponse DeleteRecipe(string id)
        {
            throw new NotImplementedException();
        }
    }
}
