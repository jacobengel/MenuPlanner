namespace MenuPlanner.WebHost.Mappers
{
    using Domain;

    public class IngredientMapper : IMapper<API.Models.Recipes.Ingredient, Domain.Models.Recipes.Ingredient>
    {
        public Domain.Models.Recipes.Ingredient Map(API.Models.Recipes.Ingredient src)
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

        public API.Models.Recipes.Ingredient Map(Domain.Models.Recipes.Ingredient src)
        {
            if (src is null)
            {
                return null;
            }

            return new API.Models.Recipes.Ingredient
            {
                Id = src.Id,
                Name = src.Name
            };
        }
    }
}