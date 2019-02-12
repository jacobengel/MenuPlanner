namespace MenuPlanner.Domain
{
    using System;

    public class Event
    {
        public string Name { get; set; }

        public EventType Type { get; set; }

        public string Description { get; set; }

        public Address Location { get; set; }

        public DateTime Date { get; set; }

        public Menu Menu { get; set; }
    }
}
