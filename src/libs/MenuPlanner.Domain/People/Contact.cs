namespace MenuPlanner.Domain.People
{
    using System;

    public class Contact : Person
    {
        public Relationship Relationship { get; set; }
    }
}
