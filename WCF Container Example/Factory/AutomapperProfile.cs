using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_Container_Example
{
    public class AutomapperProviderProfile : Profile
    {
        public AutomapperProviderProfile()
        {
            CreateMap<ContactDTO, ContactViewModel>()
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => DateTime.Now.Year - src.BirthDate.Year))
                .ReverseMap();
        }
    }
}