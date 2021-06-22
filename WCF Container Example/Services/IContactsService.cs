using System.Collections.Generic;
using System.ServiceModel;

namespace WCF_Container_Example
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IContactsService" in both code and config file together.
    [ServiceContract]
    public interface IContactsService
    {
        [OperationContract]
        IEnumerable<ContactViewModel> GetContacts();
    }
}
