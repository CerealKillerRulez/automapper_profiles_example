using System;
using System.Web.UI;

using WCF_Container_Example.ContactServiceReference;

namespace WCF_Container_Example
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           var client = new ContactsServiceClient();

            var res = client.GetContacts();
            Response.Write(res.Length);
        }
    }
}