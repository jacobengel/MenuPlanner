namespace MenuPlanner.Data.Menus.RDS
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    
    using Data;
    using Domain.Menus;

    public class IngredientsRDSRepository : RDSRepository<Ingredient>
    {
        public IngredientsRDSRepository(IDbConnection connection)
            : base(connection) {}

        protected override Dictionary<string, string> GetParameters(Ingredient ingredient) => new Dictionary<string, string>
            {
                { "Id", ingredient.Id },
                { "Name", ingredient.Name }
            };
    }
}