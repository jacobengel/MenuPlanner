namespace MenuPlanner.WebHost.Mappers
{
    using Domain.Models;

    public class ClientMapper : IMapper<API.Models.People.Client, Domain.Models.People.Client>
    {
        private IMapper<API.Models.Address, Domain.Models.Address> _addressMapper;
        private IMapper<API.Models.ContactInformation, Domain.Models.ContactInformation> _contactInformationMapper;

        public ClientMapper(
            IMapper<API.Models.Address, Domain.Models.Address> addressMapper,
            IMapper<API.Models.ContactInformation, Domain.Models.ContactInformation> contactInformationMapper)
        {
            this._addressMapper = addressMapper;
            this._contactInformationMapper = contactInformationMapper;
        }

        public Domain.Models.People.Client Map(API.Models.People.Client src)
        {
            var dest = new Domain.Models.People.Client
            {
                Id = src.Id,
                FirstName = src.FirstName,
                LastName = src.LastName,
                PreferredName = src.PreferredName,
                Address = this._addressMapper.Map(src.Address),
                ContactInformation = this._contactInformationMapper.Map(src.ContactInformation),
                //Contacts
            };

            return dest;
        }

        public API.Models.People.Client Map(Domain.Models.People.Client src)
        {
            var dest = new API.Models.People.Client
            {
                Id = src.Id,
                FirstName = src.FirstName,
                LastName = src.LastName,
                PreferredName = src.PreferredName,
                Address = this._addressMapper.Map(src.Address),
                ContactInformation = this._contactInformationMapper.Map(src.ContactInformation),
                //Contacts
            };

            return dest;
        }
    }
}