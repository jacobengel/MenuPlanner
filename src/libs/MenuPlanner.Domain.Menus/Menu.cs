namespace MenuPlanner.Domain.Menus
{
    using System.Collections.Generic;

    public class Menu
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<MenuItem> Items { get; set; }
    }
}