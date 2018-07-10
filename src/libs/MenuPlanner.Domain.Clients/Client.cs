namespace MenuPlanner.Domain.Clients
{
    using Common;

    public class Client : Person
    {
        public Address BillingAddress { get; set; }
    }
}
