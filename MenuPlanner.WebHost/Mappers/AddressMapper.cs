namespace MenuPlanner.WebHost.Mappers
{
    using Domain;

    public class AddressMapper : IMapper<Domain.Models.Address, API.Models.Address>
    {
        public Domain.Models.Address Map(API.Models.Address src)
        {
            return new Domain.Models.Address
            {
                Line1 = src.Line1,
                Line2 = src.Line2,
                City = src.City,
                State = src.State,
                ZipCode = src.ZipCode
            };
        }

        public API.Models.Address Map(Domain.Models.Address src)
        {
            return new API.Models.Address
            {
                Line1 = src.Line1,
                Line2 = src.Line2,
                City = src.City,
                State = src.State,
                ZipCode = src.ZipCode
            };
        }
    }
}