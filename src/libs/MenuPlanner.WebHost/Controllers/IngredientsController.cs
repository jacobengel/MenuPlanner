namespace MenuPlanner.WebHost.Controllers
{
    using System;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using Domain;
    
    [Route("ingredients")]
    public class IngredientsController : Controller
    {
        [HttpGet]
        public HttpResponse GetIngredients()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public HttpResponse CreateIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public HttpResponse DeleteIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
