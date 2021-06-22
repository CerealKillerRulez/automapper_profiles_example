using AutoMapper;
using System;

namespace wHospitalClassLibrary
{
    public class wHospitalCoreAutomapperProfile : Profile
    {
        public wHospitalCoreAutomapperProfile()
        {
            CreateMap<AddressDTO, AddressViewModel>().ReverseMap();
        }
    }
}
