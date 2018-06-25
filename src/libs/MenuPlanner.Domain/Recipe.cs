namespace MenuPlanner.Domain
{
    using System.Collections.Generic;

    public class Recipe
    {
        public string Name { get; set; }

        public List<string> Tags { get; set; }

        public string Instructions { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }
}
