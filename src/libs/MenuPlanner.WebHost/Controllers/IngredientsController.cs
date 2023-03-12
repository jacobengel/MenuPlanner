namespace MenuPlanner.WebHost.Controllers
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using API.Models.Recipes;
    
    [ApiController]
    [Route("ingredients")]
    public class IngredientsController : ControllerBase
    {
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Ingredient> GetIngredient([FromRoute]string id)
        {
            throw new NotImplementedException();
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Ingredient>> GetIngredients()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult CreateIngredient([FromBody]Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public ActionResult UpdateIgredient([FromRoute]string id, [FromBody]Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public HttpResponse DeleteIngredient([FromRoute]string id)
        {
            throw new NotImplementedException();
        }
    }
}
