namespace MenuPlanner.Domain.Models.Recipes
{
    public class RecipeIngredient : Ingredient
    {
        public IngredientAmount Amount { get; set; }
    }
}