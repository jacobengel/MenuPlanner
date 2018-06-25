namespace MenuPlanner.Domain.Clients
{
    using Common;

    public class Client : Person
    {
        public string Id { get; set; }

        public Address BillingAddress { get; set; }
    }
}
