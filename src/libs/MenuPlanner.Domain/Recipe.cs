namespace MenuPlanner.Domain
{
    using System;

    public class Recipe
    {
        public List<Ingredient> Ingredients { get; set; }

        public Dictionary<uint, string> Instructions { get; set; }

        public string AdditionalInstructions { get; set; }

        public uint Scale { get; set; } = 1;

        public uint Servings { get; set; }
    }
}
