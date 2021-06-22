using AutoMapper;
using System;
using System.Collections.Generic;
using Unity;
using whCoreLibrary;

namespace WCF_Container_Example
{
    public class ContactsService : IContactsService
    {
        protected readonly IMapper Mapper;
        private readonly GeoUtility Utility;

        public ContactsService()
        {
            Mapper = IoCProvider.Instance.Resolve<IMapper>();
            Utility = new GeoUtility(Mapper);
        }

        public IEnumerable<ContactViewModel> GetContacts()
        {               
            var resDTO = new List<ContactDTO> {
                new ContactDTO { FirstName = "Michele", LastName = "Panipucci", BirthDate = new DateTime(1980,5,15) }
            };

            var address = Utility.GetAddress();

            return Mapper.Map<List<ContactViewModel>>(resDTO);
        }
    }
}
