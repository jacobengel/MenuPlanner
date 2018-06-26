namespace MenuPlanner.Data.Clients.RDS
{
    using Domain.Clients;

    public class ClientConverter
    {
        public object Convert(Client client)
        {
            return new
                { 
                    client.Id,
                    client.FirstName,
                    client.LastName,
                    AddressLine1 = client.Address.Line1,
                    AddressLine2 = client.Address.Line2,
                    City = client.Address.City,
                    State = client.Address.State,
                    Zip = client.Address.Zip,
                    client.EmailAddress,
                    client.PhoneNumber,
                    BillingAddressLine1 = client.BillingAddress.Line1,
                    BillingAddressLine2 = client.BillingAddress.Line2,
                    BillingCity = client.BillingAddress.City,
                    BillingState = client.BillingAddress.State,
                    BillingZip = client.BillingAddress.Zip
                };
        }
    }
}
