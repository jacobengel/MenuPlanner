namespace MenuPlanner.WebHost.Controllers
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using API.Models.Recipes;

    [ApiController]
    [Route("recipes")]
    public class RecipesController : ControllerBase
    {
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Recipe> GetRecipe([FromRoute]string id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Recipe>> GetRecipes()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult CreateRecipe([FromBody]Recipe recipe)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public ActionResult UpdateRecipe([FromRoute]string id, [FromBody]Recipe recipe)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public ActionResult DeleteRecipe([FromRoute]string id)
        {
            throw new NotImplementedException();
        }
    }
}
