namespace MenuPlanner.Domain.Menus
{
    public class MenuItem
    {
        public string Id { get; set; }

        public Recipe Recipe { get; set; }

        public int NumberOfServings { get; set; }
    }
}
