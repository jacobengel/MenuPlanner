namespace MenuPlanner.Domain.Models
{
    using System.Collections.Generic;

    using Recipes;
    using Locations;

    public class ShoppingList
    {
        public Location Location { get; set; }

        public List<Ingredient> Items { get; set; }
    }
}
