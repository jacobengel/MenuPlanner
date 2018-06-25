namespace MenuPlanner.Domain
{
    using System.Collections.Generic;

    public class Menu
    {
        public string Name { get; set; }

        public List<MenuItem> Items { get; set; }
    }
}