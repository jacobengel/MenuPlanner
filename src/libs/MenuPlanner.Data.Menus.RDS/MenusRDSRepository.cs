namespace MenuPlanner.Data.Menus.RDS
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    using Data;
    using Domain.Menus;

    public class MenusRDSRepository : RDSRepository<Menu>
    {
        public MenusRDSRepository(IDbConnection connection)
            : base(connection) {}

        protected override Dictionary<string, string> GetParameters(Menu menu) => new Dictionary<string, string>
            {
                { "Id", menu.Id },
                { "Name", menu.Name }
            };
    }
}
