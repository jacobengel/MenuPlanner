namespace MenuPlanner.Domain.Menus
{
    using System.Collections.Generic;

    using Common;

    public class Recipe : Identifiable
    {
        public string Name { get; set; }

        public List<string> Tags { get; set; }

        public string Instructions { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }
}