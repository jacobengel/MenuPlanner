namespace MenuPlanner.Data.Clients.RDS
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    using Data;
    using Domain.Clients;

    public class ClientsRDSRepository : RDSRepository<Client>
    {
        public ClientsRDSRepository(IDbConnection connection)
            : base(connection) {}

        protected override Dictionary<string, string> GetParameters(Client client) => new Dictionary<string, string>
            {
                { "Id", client.Id },
                { "FirstName", client.FirstName },
                { "LastName", client.LastName },
                { "AddressLine1", client.Address.Line1 },
                { "AddressLine2", client.Address.Line2 },
                { "City", client.Address.City },
                { "State", client.Address.State },
                { "Zip", client.Address.Zip },
                { "EmailAddress", client.EmailAddress },
                { "PhoneNumber", client.PhoneNumber },
                { "BillingAddressLine1", client.BillingAddress.Line1 },
                { "BillingAddressLine2", client.BillingAddress.Line2 },
                { "BillingCity", client.BillingAddress.City },
                { "BillingState", client.BillingAddress.State },
                { "BillingZip", client.BillingAddress.Zip }
            };

        /* In case Dapper requires an object and it won't handle a dictionary, here's the object equivalent
        
        new { 
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
            });

         */
    }
}