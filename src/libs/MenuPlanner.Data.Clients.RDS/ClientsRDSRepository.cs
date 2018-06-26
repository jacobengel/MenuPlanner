namespace MenuPlanner.Data.Clients.RDS
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;

    using MenuPlanner.Domain.Clients;
    using MenuPlanner.Domain.Common;

    using Dapper;

    public class ClientsRDSRepository : IRepository<Client>
    {
        private readonly IDbConnection _connection;

        private const string TableName = "Clients";

        private readonly string[] columns = new[]
            {
                "Id",
                "FirstName",
                "LastName",
                "AddressLine1",
                "AddressLine2",
                "City",
                "State",
                "Zip",
                "EmailAddress",
                "PhoneNumber",
                "BillingAddressLine1",
                "BillingAddressLine2",
                "BillingCity",
                "BillingState",
                "BillingZip"
            };

        public ClientsRDSRepository(IDbConnection connection)
        {
            this._connection = connection;

            this._connection.Open();
        }

        public void Dispose()
        {
            this._connection.Close();
            this._connection.Dispose();
        }

        public Client Get(string id)
        {
            return this._connection.QuerySingle<Client>($"select * from {TableName} where Id = '{id}'");
        }

        public IList<Client> GetAll()
        {
            return this._connection.Query<Client>($"select * from {TableName}").ToList();
        }

        public void Save(Client client)
        {
            if (string.IsNullOrEmpty(client.Id))
            {
                client.Id = Guid.NewGuid().ToString();

                var insertQuery = new StringBuilder();

                insertQuery.Append($"insert into {TableName} ({string.Join(",", this.columns)}) ");
                insertQuery.Append($"values (@Id, @FirstName, @LastName, @AddressLine1, @AddressLine2, @City, @State, @Zip, @EmailAddress, @PhoneNumber, @BillingAddressLine1, @BillingAddressLine2, @BillingCity, @BillingState, @BillingZip)");

                this._connection.Execute(insertQuery.ToString(), new
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
                    });
            }
            else 
            {
                var updateQuery = new StringBuilder();

                updateQuery.Append($"update {TableName} ");
                updateQuery.Append($"set FirstName = @FirstName, ");
                updateQuery.Append($"LastName = @LastName, ");
                updateQuery.Append($"AddressLine1 = @AddressLine1, ");
                updateQuery.Append($"AddressLine2 = @AddressLine2, ");
                updateQuery.Append($"City = @City, ");
                updateQuery.Append($"State = @State, ");
                updateQuery.Append($"Zip = @Zip, ");
                updateQuery.Append($"EmailAddress = @EmailAddress, ");
                updateQuery.Append($"BillingAddressLine1 = @BillingAddressLine1, ");
                updateQuery.Append($"BillingAddressLine2 = @BillingAddressLine2, ");
                updateQuery.Append($"BillingCity = @BillingCity, ");
                updateQuery.Append($"BillingState = @BillingState, ");
                updateQuery.Append($"BillZip = @BillingZip, ");

            }
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}