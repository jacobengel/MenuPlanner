namespace MenuPlanner.Domain.Menus
{
    using Common;

    public class Ingredient : Identifiable
    {
        public string Name { get; set; }

        public double? Amount { get; set; }

        public Unit? Unit { get; set; }
    }
}