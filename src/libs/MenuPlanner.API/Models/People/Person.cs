namespace MenuPlanner.API.Models.People
{
    public class Person
    {
        public string Id { get; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PreferredName { get; set; }

        public ContactInformation ContactInformation { get; set; }

        public Address Address { get; set; }
    }
}