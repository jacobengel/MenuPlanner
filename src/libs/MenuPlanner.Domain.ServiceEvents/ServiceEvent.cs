namespace MenuPlanner.Domain.ServiceEvents
{
    using System;

    using Common;

    public class ServiceEvent : Identifiable
    {
        public string Date => this.DateTime.ToString("MM/dd/yyyy");

        public string Time => this.DateTime.ToString("HH:mm");

        public DateTime DateTime { get; set; }

        public ServiceEventType Type { get; set; }
    }
}