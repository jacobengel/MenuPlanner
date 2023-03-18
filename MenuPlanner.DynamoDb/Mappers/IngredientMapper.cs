namespace MenuPlanner.DynamoDb.Mappers
{
    using Domain;

    public class IngredientMapper : IMapper<Models.Recipes.Ingredient, Domain.Models.Recipes.Ingredient>
    {
        public Domain.Models.Recipes.Ingredient Map(Models.Recipes.Ingredient src)
        {
            if (src is null)
            {
                return null;
            }

            return new Domain.Models.Recipes.Ingredient
            {
                Id = src.Id,
                Name = src.Name
            };
        }

        public Models.Recipes.Ingredient Map(Domain.Models.Recipes.Ingredient src)
        {
            if (src is null)
            {
                return null;
            }

            return new Models.Recipes.Ingredient
            {
                Id = src.Id,
                Name = src.Name
            };
        }
    }
}