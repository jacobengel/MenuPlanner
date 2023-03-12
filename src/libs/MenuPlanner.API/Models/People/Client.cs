namespace MenuPlanner.API.Models.People
{
    using System.Collections.Generic;

    public class Client : Person
    {        
        public List<Contact> Contacts { get; set; }    
    }
}