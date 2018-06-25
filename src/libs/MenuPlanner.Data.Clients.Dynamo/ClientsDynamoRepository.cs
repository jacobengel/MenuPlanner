namespace MenuPlanner.Data.Clients.Dynamo
{
    using System;
    using System.Collections.Generic;

    using Amazon.DynamoDBv2;
    using Amazon.DynamoDBv2.Model;

    using Domain.Clients;
    using Domain.Common;

    public class ClientsDynamoRepository : IRepository<Client>
    {
        private readonly IAmazonDynamoDB _dynamoClient;

        private const string TableName = "clients";

        public ClientsDynamoRepository(IAmazonDynamoDB dynamoClient)
        {
            this._dynamoClient = dynamoClient;
        }

        public Client Get(string id)
        {
            var key = new Dictionary<string, AttributeValue> {{ "id", new AttributeValue(id) }};
            var getItemRequest = new GetItemRequest(TableName, key);

            var response = this._dynamoClient.GetItemAsync(getItemRequest).Result;

            var client = ClientConverter.Convert(response.Item);

            return client;
        }

        public IList<Client> GetAll()
        {
            
        }

        public void Save(Client client)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
