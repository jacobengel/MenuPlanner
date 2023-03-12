namespace MenuPlanner.API.Models.People
{
    public class Contact
    {
        public string Id { get; set; }

        public Relationship? RelationshipToClient { get; set; }
    }
}