namespace MenuPlanner.API.Models.Events
{
    using System;

    public class Event
    {
        public string Name { get; set; }

        public EventType? Type { get; set; }

        public string Description { get; set; }

        public Address Location { get; set; }

        public DateTime Date { get; set; }

        public string MenuId { get; set; }

        public Recurrence Recurrence { get; set; }
    }
}