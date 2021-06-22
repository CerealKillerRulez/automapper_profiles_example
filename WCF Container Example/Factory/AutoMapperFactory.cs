using AutoMapper;
using AutoMapper.Configuration;
using System;
using System.Linq;
using whCoreLibrary;

namespace WCF_Container_Example
{
    public static class AutoMapperFactory
    {
        public static IConfigurationProvider BuildConfiguration()
        {
            var config = new MapperConfiguration(cfg => {                
                cfg.AddProfile(new AutomapperProviderProfile());
                cfg.AddProfiles(new[] { "whCoreLibrary" });
            });

            config.AssertConfigurationIsValid();

            return config;
        }

        private static void GetConfiguration(IConfiguration configuration)
        {
            
            
        }
    }
}
