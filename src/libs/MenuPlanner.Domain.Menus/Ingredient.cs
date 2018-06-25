namespace MenuPlanner.Domain.Menus
{
    public class Ingredient
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public double? Amount { get; set; }

        public Unit? Unit { get; set; }
    }
}
