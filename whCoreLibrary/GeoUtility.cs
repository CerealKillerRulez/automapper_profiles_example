using AutoMapper;

namespace whCoreLibrary
{
    public class GeoUtility
    {
        private readonly IMapper Mapper;


        public GeoUtility(IMapper mapper)
        {
            Mapper = mapper;
        }

        public AddressViewModel GetAddress()
        {
            return Mapper.Map<AddressViewModel>(
                new AddressDTO {
                    Country = "Italy",
                    City = "San Zenone al Lambro",
                    Address = "via Brian 3C",
                    ZipCode = "20070"
                }
            );
        }
    }
}
