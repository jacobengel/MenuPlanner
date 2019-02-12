namespace MenuPlanner.Domain
{
    using System;
    using System.Collections.Generic;

    public class ShoppingList
    {
        public ShoppingLocation Location { get; set; }

        public List<Ingredient> Items { get; set; }
    }
}
