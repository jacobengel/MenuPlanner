namespace MenuPlanner.Domain.People
{
    using System;

    public class Person
    {
        public string FirstName { get; set; }

        public string LastName  { get; set; }

        public string FullName
        {
            get
            { 
                if (string.IsNullOrEmpty(this.FirstName) || string.IsNullOrEmpty(this.LastName))
                {
                    return string.Empty;
                }
                
                return string.Join(" ", this.FirstName, this.LastName);
            }
        }

        public ContactInformation ContactInformation { get; set; }

        public Address Address { get; set; }
    }
}
