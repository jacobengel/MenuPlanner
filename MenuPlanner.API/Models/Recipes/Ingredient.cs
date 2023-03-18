namespace MenuPlanner.API.Models.Recipes
{
    using System.ComponentModel.DataAnnotations;

    public class Ingredient
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}