namespace MenuPlanner.WebHost.Controllers
{
    using System;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using API.Models.Recipes;
    
    [Route("ingredients")]
    public class IngredientsController : Controller
    {
        [HttpGet("{id}")]
        public HttpResponse GetIngredient(string id)
        {
            throw new NotImplementedException();
        }
        
        [HttpGet]
        public HttpResponse GetIngredients()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public HttpResponse CreateIngredient([FromBody]Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public HttpResponse UpdateIgredient(string id, [FromBody]Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public HttpResponse DeleteIngredient(string id)
        {
            throw new NotImplementedException();
        }
    }
}
