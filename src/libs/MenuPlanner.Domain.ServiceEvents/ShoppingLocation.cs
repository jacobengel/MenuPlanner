namespace MenuPlanner.Domain.ServiceEvents
{
    using Common;

    public class ShoppingLocation : Identifiable
    {
        public string Name { get; set; }

        public Address Address { get; set; }
    }
}
