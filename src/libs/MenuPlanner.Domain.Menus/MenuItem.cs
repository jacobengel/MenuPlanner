namespace MenuPlanner.Domain.Menus
{
    using Common;

    public class MenuItem : Identifiable
    {
        public Recipe Recipe { get; set; }

        public int NumberOfServings { get; set; }
    }
}