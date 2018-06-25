namespace MenuPlanner.Data.Clients.Dynamo
{
    using System.Collections.Generic;

    using Amazon.DynamoDBv2.Model;

    using Domain.Clients;
    using Domain.Common;

    using Newtonsoft.Json;

    public static class ClientConverter
    {
        public static Client Convert(Dictionary<string, AttributeValue> item)
        {
            var client = new Client();
            
            client.Id = item["id"].ToString();

            client.FirstName = item["firstName"].ToString();
            client.LastName = item["lastName"].ToString();
            
            client.EmailAddress = item["emailAddress"].ToString();
            client.PhoneNumber = item["phoneNumber"].ToString();

            client.BillingAddress = JsonConvert.DeserializeObject<Address>(item["billingAddress"].ToString());
            client.Address = JsonConvert.DeserializeObject<Address>(item["address"].ToString());

            return client;
        }
    }
}
