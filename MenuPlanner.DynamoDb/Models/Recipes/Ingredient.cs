namespace MenuPlanner.DynamoDb.Models.Recipes
{
    using Amazon.DynamoDBv2.DataModel;
    
    [DynamoDBTable("mm-dev")]
    public class Ingredient
    {
        [DynamoDBRangeKey("id")]
        public string? Id { get; set; }

        [DynamoDBHashKey("category")]
        public string Category = "Ingredient";

        [DynamoDBProperty("name")]
        public string? Name { get; set; }
    }
}