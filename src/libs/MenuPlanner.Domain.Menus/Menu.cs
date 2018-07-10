namespace MenuPlanner.Domain.Menus
{
    using System.Collections.Generic;

    using Common;

    public class Menu : Identifiable
    {
        public string Name { get; set; }

        public List<MenuItem> Items { get; set; }
    }
}