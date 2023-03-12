namespace MenuPlanner.API.Models.Recipes
{
    using System.Collections.Generic;

    public class Recipe
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<RecipeIngredient> Ingredients { get; set; }

        public Dictionary<uint, string> Instructions { get; set; }

        public string AdditionalInstructions { get; set; }

        public uint Scale { get; set; }

        public uint Servings { get; set; }
    }
}