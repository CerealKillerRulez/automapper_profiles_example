using AutoMapper;

namespace whCoreLibrary
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<AddressDTO, AddressViewModel>()
                .ForMember(dest => dest.AddressField, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.CityField, opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.CountryField, opt => opt.MapFrom(src => src.Country))
                .ForMember(dest => dest.ZipCodeField, opt => opt.MapFrom(src => src.ZipCode))
                .ReverseMap();
        }
    }
}
