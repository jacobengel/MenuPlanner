namespace MenuPlanner.Common
{
    public abstract class Person : Identifiable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address Address { get; set; } = new Address();

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }
    }
}
