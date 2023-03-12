namespace MenuPlanner.Domain.Models.Events
{
    using System.Collections.Generic;

    using Recipes;

    public class Menu
    {
        public List<Recipe> Recipes { get; set; }
    }
}
