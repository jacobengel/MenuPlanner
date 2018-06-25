namespace MenuPlanner.Domain
{
    using System;

    public class ServiceDay
    {
        public string Date => this.DateTime.ToString("MM/dd/yyyy");

        public string Time => this.DateTime.ToString("HH:mm");

        public DateTime DateTime { get; set; }
    }
}