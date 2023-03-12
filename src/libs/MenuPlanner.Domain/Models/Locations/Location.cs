namespace MenuPlanner.Domain.Models.Locations
{
    using System.Collections.Generic;

    using People;

    public class Location
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public LocationType Type { get; set; }
        
        public Address Address { get; set; }

        public ContactInformation ContactInformation { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}