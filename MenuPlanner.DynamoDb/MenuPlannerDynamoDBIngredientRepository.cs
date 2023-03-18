namespace MenuPlanner.DynamoDb
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Amazon.DynamoDBv2.DataModel;
    using Amazon.DynamoDBv2.DocumentModel;
    
    using Domain;
    using Models.Recipes;

    public class MenuPlannerDynamoDBIngredientRepository : IMenuPlannerRepository<Domain.Models.Recipes.Ingredient>
    {
        private IDynamoDBContext _context;
        private IMapper<Ingredient, Domain.Models.Recipes.Ingredient> _ingredientMapper;

        public MenuPlannerDynamoDBIngredientRepository(
            IDynamoDBContext context,
            IMapper<Ingredient, Domain.Models.Recipes.Ingredient> ingredientMapper)
        {
            this._context = context;
            this._ingredientMapper = ingredientMapper;
        }

        public async Task<Domain.Models.Recipes.Ingredient> GetAsync(string id)
        {
            var ingredient = await this._context.LoadAsync<Ingredient>(DynamoDbConstants.IngredientCategory, id);

            if (ingredient is null)
            {
                return null;
            }

            return this._ingredientMapper.Map(ingredient);
        }

        public async Task<List<Domain.Models.Recipes.Ingredient>> GetAsync()
        {
            var queryFilter = new QueryFilter(DynamoDbConstants.Category, QueryOperator.Equal, DynamoDbConstants.IngredientCategory);

            var queryOperationConfig = new QueryOperationConfig { Filter = queryFilter };

            var search = this._context.FromQueryAsync<Ingredient>(queryOperationConfig);

            var ingredients = await search.GetRemainingAsync();

            return ingredients.Select(this._ingredientMapper.Map).ToList();
        }

        public async Task<string> CreateAsync(Domain.Models.Recipes.Ingredient ingredient)
        {
            var id = Guid.NewGuid().ToString();
            ingredient.Id = id;

            var dbIngredient = this._ingredientMapper.Map(ingredient);

            await this._context.SaveAsync(dbIngredient);

            return id;
        }

        public async Task UpdateAsync(Domain.Models.Recipes.Ingredient ingredient)
        {
            var dbIngredient = this._ingredientMapper.Map(ingredient);

            await this._context.SaveAsync(dbIngredient);
        }

        public async Task DeleteAsync(string id)
        {
            await this._context.DeleteAsync<Ingredient>(DynamoDbConstants.IngredientCategory, id);
        }
    }
}
