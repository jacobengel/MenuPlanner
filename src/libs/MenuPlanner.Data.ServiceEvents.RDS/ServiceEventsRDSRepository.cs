namespace MenuPlanner.Data.ServiceEvents.RDS
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    using Data;
    using Domain.ServiceEvents;

    public class ServiceEventsRDSRepository : RDSRepository<ServiceEvent>
    {
        public ServiceEventsRDSRepository(IDbConnection connection)
            : base(connection) {}
        
        protected override Dictionary<string, string> GetParameters(ServiceEvent serviceEvent) => new Dictionary<string, string>
            {
                { "Id", serviceEvent.Id },
                { "DateTime", serviceEvent.DateTime.ToString() },
                { "Type", serviceEvent.Type.ToString() }
            };
    }
}