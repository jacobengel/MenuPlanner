namespace MenuPlanner.Domain.People
{
    using System;
    using System.Collections.Generic;

    public class Client : Person
    {
        public List<Contact> Contacts { get; set; }
    }
}
