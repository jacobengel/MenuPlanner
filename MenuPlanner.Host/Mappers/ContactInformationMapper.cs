namespace MenuPlanner.WebHost.Mappers
{
    using Domain.Models;

    public class ContactInformationMapper : IMapper<Domain.Models.ContactInformation, API.Models.ContactInformation>
    {
        public API.Models.ContactInformation Map(Domain.Models.ContactInformation src)
        {
            return new API.Models.ContactInformation
            {
                EmailAddress = src.EmailAddress,
                PhoneNumber = src.PhoneNumber
            };
        }

        public Domain.Models.ContactInformation Map(API.Models.ContactInformation src)
        {
            return new Domain.Models.ContactInformation
            {
                EmailAddress = src.EmailAddress,
                PhoneNumber = src.PhoneNumber
            };
        }
    }
}