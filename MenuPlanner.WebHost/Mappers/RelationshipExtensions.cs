namespace MenuPlanner.WebHost.Mappers
{
    using System;

    public static class RelationshipExtensions
    {
        public static Domain.Models.People.Relationship? Convert(this API.Models.People.Relationship? relationship)
        {
            switch (relationship)
            {
                case API.Models.People.Relationship.Spouse:
                    return Domain.Models.People.Relationship.Spouse;
                case API.Models.People.Relationship.Child:
                    return Domain.Models.People.Relationship.Child;
                case API.Models.People.Relationship.Parent:
                    return Domain.Models.People.Relationship.Parent;
                case API.Models.People.Relationship.Grandparent:
                    return Domain.Models.People.Relationship.Grandparent;
                case API.Models.People.Relationship.Other:
                    return Domain.Models.People.Relationship.Other;
                case null:
                    return null;
            }

            throw new ArgumentException($"Relationship type '{relationship.ToString()}' not supported.", "relationship");
        }

        public static API.Models.People.Relationship? Convert(this Domain.Models.People.Relationship? relationship)
        {
            switch (relationship)
            {
                case Domain.Models.People.Relationship.Spouse:
                    return API.Models.People.Relationship.Spouse;
                case Domain.Models.People.Relationship.Child:
                    return API.Models.People.Relationship.Child;
                case Domain.Models.People.Relationship.Parent:
                    return API.Models.People.Relationship.Parent;
                case Domain.Models.People.Relationship.Grandparent:
                    return API.Models.People.Relationship.Grandparent;
                case Domain.Models.People.Relationship.Other:
                    return API.Models.People.Relationship.Other;
                case null:
                    return null;
            }

            throw new ArgumentException($"Relationship type '{relationship.ToString()}' not supported.", "relationship");
        }
    }
}