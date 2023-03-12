namespace MenuPlanner.API.Models.Events
{
    using System;
    using System.Collections.Generic;

    public class Recurrence
    {
        public ReccurrenceType Type { get; set; }

        public List<DayOfWeek> Days { get; set; }
    }
}