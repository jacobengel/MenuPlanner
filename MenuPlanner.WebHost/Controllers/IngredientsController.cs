namespace MenuPlanner.WebHost.Controllers
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using API.Models.Recipes;
    using Domain;
    
    [ApiController]
    [Route("ingredients")]
    public class IngredientsController : ControllerBase
    {
        private IMenuPlannerRepository<Domain.Models.Recipes.Ingredient> _repository;
        private IMapper<API.Models.Recipes.Ingredient, Domain.Models.Recipes.Ingredient> _ingredientMapper;

        public IngredientsController(
            IMenuPlannerRepository<Domain.Models.Recipes.Ingredient> repository,
            IMapper<API.Models.Recipes.Ingredient, Domain.Models.Recipes.Ingredient> ingredientMapper)
        {
            this._repository = repository;
            this._ingredientMapper = ingredientMapper;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetIngredient([FromRoute]string id)
        {
            var ingredient = await this._repository.GetAsync(id);

            if (ingredient is null)
            {
                return NotFound();
            }

            return Ok(this._ingredientMapper.Map(ingredient));
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetIngredients()
        {
            var ingredients = await this._repository.GetAsync();

            return Ok(ingredients.Select(this._ingredientMapper.Map).ToList());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateIngredient([FromBody]Ingredient ingredient)
        {
            var domIngredient = this._ingredientMapper.Map(ingredient);

            var id = await this._repository.CreateAsync(domIngredient);

            return Ok(id);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateIgredient([FromRoute]string id, [FromBody]Ingredient ingredient)
        {
            if (ingredient is null || string.IsNullOrEmpty(id))
            {
                return BadRequest();
            }
            
            ingredient.Id = id;
            var domIngredient = this._ingredientMapper.Map(ingredient);

            await this._repository.UpdateAsync(domIngredient);

            return Accepted();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public async Task<IActionResult> DeleteIngredient([FromRoute]string id)
        {
            await this._repository.DeleteAsync(id);

            return Accepted();
        }
    }
}
